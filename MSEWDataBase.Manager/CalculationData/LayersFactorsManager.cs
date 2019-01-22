using MSEWDataBase.Base.Model;
using System.Linq;


namespace MSEWDataBase.Manager.CalculationData
{
    public class LayersFactorsManager : LayerBaseManager
    {

        internal override bool IsLineValid(string line)
        {
            if (line.Split(' ').Count() >= 11)
            {
                var elements = line.Split(' ').Take(10);
                double temp;
                foreach (var element in elements)
                {
                    if (!double.TryParse(element, out temp)) return false;
                }
                return true;
            }
            return false;
        }


        public override Layer ResovleSingle(string line)
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

        public override Layer ResovleSingle(string line, Layer baseLayer)
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

                baseLayer.Elevation = elevation;
                baseLayer.ProductName = productName;
                baseLayer.Length = length;
                baseLayer.ConnectionStrengthCDR = connectionStrengthCDR;
                baseLayer.GeogridStrengthCDR = geogridStrengthCDR;
                baseLayer.DirectSlidingCDR = directSlidingCDR;
                baseLayer.Eccentricity = eccentricity;
                baseLayer.PulloutResistanceCDR = pulloutResistanceCDR;
 
            }
            return baseLayer;
        }
    }
}
