using MSEWDataBase.Base.Model;
using System.Collections.Generic;

namespace MSEWDataBase.Base.Manager
{
    public interface ILayerRetrieveManager
    {
        IEnumerable<Layer> Resolve(IEnumerable<string> lines);
        IEnumerable<Layer> Resolve(IEnumerable<string> lines, IEnumerable<Layer> baseLayers);
        Layer ResovleSingle(string line);
        Layer ResovleSingle(string line,Layer baseLayer);
        IEnumerable<string> GetValidLines(IEnumerable<string> lines);
    }
}
