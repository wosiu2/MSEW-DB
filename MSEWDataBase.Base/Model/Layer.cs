using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Base.Model
{
    public class Layer:IStorable
    {
        public ObjectId Id { get; set; }
        public ObjectId CalculationId { get; set; }

        public string ProductName { get; set; }
        public double Elevation { get; set; }
        public double Strength { get; set; }
        public double Length { get; set; }

        public double ConnectionStrengthCDR { get; set; }
        public double GeogridStrengthCDR { get; set; }
        public double PulloutResistanceCDR { get; set; }
        public double DirectSlidingCDR { get; set; }
        public double Eccentricity { get; set; }


    }
}
