using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MSEWDataBase.Base.Model
{
    public class Company : IStorable
    {
        public ObjectId Id { get ; set ; }
        public string Name { get; set; }

    }
}
