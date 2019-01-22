using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.CalculationData
{
    public class LayersStrengthManager : LayerBaseManager
    {


        public override Layer ResovleSingle(string line)
        {
            if (IsLineValid(line))
            {
                var aLine = line.Split(' ');
                double.TryParse(aLine[2], out double availableStrength);
                double.TryParse(aLine[3], out double forceActing);


                var layer = new Layer()
                {
                    Strength = availableStrength
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
                double.TryParse(aLine[2], out double availableStrength);
                double.TryParse(aLine[3], out double forceActing);

                baseLayer.Strength = availableStrength;
                baseLayer.ForceActing = forceActing;

            }
            return baseLayer;
        }

        internal override bool IsLineValid(string line)
        {
            if (line.Split(' ').Count() >= 10)
            {
                var elements = line.Split(' ').Take(9);
                double temp;
                foreach (var element in elements)
                {
                    if (!(double.TryParse(element, out temp) || element == "N/A")) return false;
                }
                return true;
            }
            return false;
        }
    }
}
