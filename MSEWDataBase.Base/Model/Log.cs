using MongoDB.Bson;
using System;


namespace MSEWDataBase.Base.Model
{
    public class Log : IStorable
    {
        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public DateTime LoginDate { get; set; }

        public Log()
        {
            LoginDate = DateTime.Now;
        }
    }
}
