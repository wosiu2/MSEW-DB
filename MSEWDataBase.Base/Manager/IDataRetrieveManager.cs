using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Base.Manager
{
    public interface IDataRetrieveManager
    {
        Calculation Resolve(IEnumerable<string> lines);
        Calculation Resolve(IEnumerable<string> lines, Calculation baseCalculation);

        IEnumerable<string> GetValidLines(IEnumerable<string> lines);
    }
}
