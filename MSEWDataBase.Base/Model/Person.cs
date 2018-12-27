using MongoDB.Bson;
using MSEWDataBase.Base.Enum;

namespace MSEWDataBase.Base.Model
{
    public class Person : IStorable
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Company Company { get; set; }
        public Positions Position { get; set; }
    }
}
