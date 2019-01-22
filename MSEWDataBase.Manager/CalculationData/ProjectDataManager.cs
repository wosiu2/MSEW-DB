using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;

namespace MSEWDataBase.Manager.CalculationData
{
    public class ProjectDataManager : IDataRetrieveManager
    {

        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            var projectList = new[]{"Title",
                             "Project Number",
                             "Designer"
                             };

            return lines.Where(x=> projectList.Any(y=>x.Contains(y)));
        }

        public  Calculation Resolve(IEnumerable<string> lines)
        {
            throw new NotImplementedException();
        }

        public  Calculation Resolve(IEnumerable<string> lines, Calculation baseCalculation)
        {
            throw new NotImplementedException();
        }

        private IDictionary<string,string> GetDictionary(IEnumerable<string> validLines)
        {
            var dictionary = new Dictionary<string, string>();

            foreach(var element in validLines)
            {

            }

            return dictionary;


        }
    }
}
