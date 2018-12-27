using MongoDB.Bson;
using MSEWDataBase.Base.Enum;


namespace MSEWDataBase.Base.Model
{
    public class User : IStorable
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Privileges Role { get; set; }
    }

}
