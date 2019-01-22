using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.CalculationData
{
    public abstract class LayerBaseManager : ILayerRetrieveManager
    {
        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            return lines.Where(x => IsLineValid(x));
        }

        internal abstract bool IsLineValid(string line);

        public IEnumerable<Layer> Resolve(IEnumerable<string> lines)
        {
            var validLines = GetValidLines(lines);

            return validLines.Select(x => ResovleSingle(x));
        }

        public abstract Layer ResovleSingle(string line);
        public abstract Layer ResovleSingle(string line, Layer baseLayer);

        public IEnumerable<Layer> Resolve(IEnumerable<string> lines, IEnumerable<Layer> baseLayers)
        {
            var validLines = GetValidLines(lines);
            var validData = validLines.Zip(baseLayers,(x,y)=>new { line=x,layer=y});

            return validData.Select(x => ResovleSingle(x.line,x.layer));
        }
    }
}
