using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.CalculationData
{
    public abstract class BaseDataManager : IDataRetrieveManager
    {
        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            var projectList = new[]{"Title:",
                             "Project Number:",
                             "Designer:"
                             };
            return lines.Where(x => IsLineValid(x));
        }

        
        internal abstract bool IsLineValid(string line);

        public abstract Calculation Resolve(IEnumerable<string> lines);

        public abstract Calculation Resolve(IEnumerable<string> lines, Calculation baseCalculation);

    }
}
