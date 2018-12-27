using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;
using System.Linq;


namespace MSEWDataBase.Manager.CalculationData
{
    public class LayersFactorsManager: ILayerRetriveManager
    {
        public IEnumerable<string> GetValidLines(IEnumerable<string> lines)
        {
            return lines.Where(x => IsLineValid(x));
        }

        private bool IsLineValid(string line)
        {
            if (line.Split(' ').Count()>=11)
            {
                var elements = line.Split(' ').Take(10);
                double temp;
                foreach(var element in elements)
                {
                    if (!double.TryParse(element, out temp)) return false ;
                }
                return true;
            }          
            return false;
        }

        public IEnumerable<Layer> Resolve(IEnumerable<string> lines)
        {
            var validLines = GetValidLines(lines);

            return validLines.Select(x => ResovleSingle(x));
        }

        public Layer ResovleSingle(string line)
        {

            if (IsLineValid(line))
            {
                var aLine = line.Split(' ');
                double.TryParse(aLine[1], out double elevation);
                double.TryParse(aLine[2], out double length);
                double.TryParse(aLine[4], out double connectionStrengthCDR);
                double.TryParse(aLine[6], out double geogridStrengthCDR);
                double.TryParse(aLine[7], out double pulloutResistanceCDR);
                double.TryParse(aLine[8], out double directSlidingCDR);
                double.TryParse(aLine[9], out double eccentricity);

                string productName = "";

                for (var i = 10; i < aLine.Length; i++)
                {
                    productName += aLine[i];
                }

                var layer = new Layer()
                {
                    Elevation = elevation,
                    ProductName = productName,
                    Length = length,
                    ConnectionStrengthCDR = connectionStrengthCDR,
                    GeogridStrengthCDR = geogridStrengthCDR,
                    DirectSlidingCDR = directSlidingCDR,
                    Eccentricity = eccentricity,
                    PulloutResistanceCDR = pulloutResistanceCDR
                };

                return layer;
            }
            else
            {
                return new Layer();
            }
        }
    }
}
