using MongoDB.Bson;

namespace MSEWDataBase.Base.Model
{
    public class StripLoad
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Center { get; set; }
        public double Value { get; set; }
    }
}