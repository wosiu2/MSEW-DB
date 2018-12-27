using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.CalculationData
{
    public class LayersPulloutManager : ILayerRetriveManager
    {
        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Layer> Resolve(IEnumerable<string> lines)
        {
            throw new NotImplementedException();
        }

        public Layer ResovleSingle(string line)
        {
            throw new NotImplementedException();
        }
    }
}
