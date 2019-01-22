using MSEWDataBase.Base.Manager;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.CalculationData
{
    public class LayersPulloutManager : LayerBaseManager
    {
 
        public override Layer ResovleSingle(string line)
        {
            if (IsLineValid(line))
            {
                var aLine = line.Split(' ');
                double.TryParse(aLine[5], out double resistanceLength);
                double.TryParse(aLine[6], out double activeLength);
                double.TryParse(aLine[7], out double resistanceForce);

                var layer = new Layer()
                {
                    PulloutResistanceForce = resistanceForce,
                    PulloutActiveLength = activeLength,
                    PulloutResistanceLength= resistanceLength
                };

                return layer;
            }
            else
            {
                return new Layer();
            }
        }

        public override Layer ResovleSingle(string line,Layer baseLayer)
        {
            if (IsLineValid(line))
            {
                var aLine = line.Split(' ');
                double.TryParse(aLine[5], out double resistanceLength);
                double.TryParse(aLine[6], out double activeLength);
                double.TryParse(aLine[7], out double resistanceForce);

                baseLayer.PulloutResistanceForce = resistanceForce;
                baseLayer.PulloutActiveLength = activeLength;
                baseLayer.PulloutResistanceLength = resistanceLength;
            }
            return baseLayer;
        }

        internal override bool IsLineValid(string line)
        {
            if (line.Split(' ').Count() >= 13)
            {
                var elements = line.Split(' ').Take(13);
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
