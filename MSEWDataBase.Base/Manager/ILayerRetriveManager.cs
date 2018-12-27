using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Base.Manager
{
    public interface ILayerRetriveManager
    {
        IEnumerable<Layer> Resolve(IEnumerable<string> lines);
        Layer ResovleSingle(string line);
        IEnumerable<string> GetValidLines(IEnumerable<string> lines);
    }
}
