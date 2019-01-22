using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;


namespace MSEWDataBase.Base.Model
{
    public class Calculation:IStorable
    {
        //Id data
        public ObjectId Id { get; set; }
        public ObjectId ProjectId { get; set; }

        // Designer data
        public Person Designer { get; set; }

        //Loads

        public ICollection<StripLoad> StripLoads { get; set; }
        public string LoadModel;

        //Geometry
        public CalculationWallGeometry Geometry { get; set; }

        //Soil used in calculaions
        public Soil RetainedSoil { get; set; }
        public Soil ReinforcedSoil { get; set; }
        public Soil FoundationSoil { get; set; }

        // Global stability Resistance coefficients
        public double DirectSlidingCDR { get; set; }
        public double OverturningCDR { get; set; }
        public double Eccentricity { get; set; }

        // Bearing results under reinforced block of soil
        public double FactoredBearingLoad { get; set; }
        public double UnfactoredBearingLoad { get; set; }
        public double FactoredBearingResistance { get; set; }
        public double BearingCDR { get; set; }



        // Confguration of geosintetic layers 

        public ICollection<Layer> Layers { get; set; }
    }
}
