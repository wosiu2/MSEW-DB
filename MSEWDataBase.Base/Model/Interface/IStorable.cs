using MongoDB.Bson;

namespace MSEWDataBase.Base.Model
{
    public interface IStorable
    {
        ObjectId Id { get; set; }
    }
}
