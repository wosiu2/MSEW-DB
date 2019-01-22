using MongoDB.Bson;

namespace MSEWDataBase.Base.Model
{
    public class Company : IStorable
    {
        public ObjectId Id { get ; set ; }
        public string Name { get; set; }

    }
}
