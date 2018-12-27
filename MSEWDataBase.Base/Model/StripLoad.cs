using MongoDB.Bson;

namespace MSEWDataBase.Base.Model
{
    public class StripLoad
    {
        public ObjectId Id { get; set; }
        public ObjectId CalculationId { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public double Center { get; set; }
        public double Value { get; set; }
    }
}