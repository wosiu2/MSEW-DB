using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MSEWDataBase.Manager.CalculationData
{
    public class SoilDataManager : ISoilRetrieveManager
    {
        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            var projectList = new[]{"weight",
                             "angle of friction",
                             "cohesion"
                             };

            return lines.Where(x => projectList.Any(y => x.Contains(y)));
        }

        public Soil Resolve(IEnumerable<string> lines)
        {
            var validLines = GetValidLines(lines);
            var soil = new Soil();

            foreach (var line in validLines)
            {
                if(line.Contains("angle of friction")) soil.FrictionAngle= double.Parse(Regex.Match(line, @"\d*\.\d+").Value);
                if (line.Contains("cohesion")) soil.Cohesion = double.Parse(Regex.Match(line, @"\d*\.\d+").Value);
                if (line.Contains("weight")) soil.UnitWeight = double.Parse(Regex.Match(line, @"\d*\.\d+").Value);

            }

            return soil;
        }

    }
}
