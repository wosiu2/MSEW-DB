using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MSEWDataBase.Base.Model
{
    public class Project : IStorable
    {
        public ObjectId Id { get; set; }

        public int Year { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }

        public ICollection<Company> Country { get; set; }
        public ICollection<Person> Involved { get; set; }
        public Person MainDesigner { get; set; }

        [BsonIgnore]
        public ICollection<Calculation> Calculations { get; set; }
    }
}
