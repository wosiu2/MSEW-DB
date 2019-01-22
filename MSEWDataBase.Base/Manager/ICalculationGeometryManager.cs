using MSEWDataBase.Base.Model;
using System.Collections.Generic;


namespace MSEWDataBase.Base.Manager
{
    public interface ICalculationGeometryManager
    {
        CalculationWallGeometry Resolve(IEnumerable<string> lines);
        IEnumerable<string> GetValidLines(IEnumerable<string> lines);
    }
}
