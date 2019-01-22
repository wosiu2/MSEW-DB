using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.CalculationData
{
    public class WallGeometryManager : ICalculationGeometryManager
    {
        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            var projectList = new[]{"Design height",
                             "Batter",
                             "Backslope",
                             "Backslope rise"
                             };

            return lines.Where(x => projectList.Any(y => x.Contains(y)));
        }

        public CalculationWallGeometry Resolve(IEnumerable<string> lines)
        {
            var validLines = GetValidLines(lines);
            var geometry = new CalculationWallGeometry();

            foreach (var line in validLines)
            {
                if (line.Contains("Design height")) geometry.CalculationHeight = double.Parse(Regex.Match(line, @"\d*\.\d+").Value);
                if (line.Contains("Backslope")) geometry.BackslopeAngle = double.Parse(Regex.Match(line, @"\d*\.\d+").Value);
                if (line.Contains("Backslope rise")) geometry.BackslopeRise = double.Parse(Regex.Match(line, @"\d*\.\d+").Value);
                if (line.Contains("Batter")) geometry.BatterAngle = double.Parse(Regex.Match(line, @"\d*\.\d+").Value);
            }

            return geometry;
        }
    }
}
