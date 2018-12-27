using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MSEWDataBase.Base.Model;

namespace MSEWDataBase.Base.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T:class,IStorable
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<T> _collection;

        public BaseRepository(IMongoClient client,string dbName="MSEWDB")
        {
            _client = client;
            _database = _client.GetDatabase(dbName);
            _collection = _database.GetCollection<T>(typeof(T).Name + "s");

        }

        public void Add(T entity)
        {
            _collection.InsertOne(entity);
        }

        public void Add(IEnumerable<T> entities)
        {
            _collection.InsertMany(entities);
        }

        public void Delete(T entity)
        {
            _collection.DeleteOne(x => x.Id == entity.Id);
        }

        public void Delete(IEnumerable<T> entities)
        {
            foreach(var e in entities)
            {
                Delete(e);
            }
        }

        public void Edit(T entity)
        {
            _collection.ReplaceOne<T>(x => x.Id == entity.Id, entity);
        }

        public void Edit(IEnumerable<T> entities)
        {
            foreach(var e in entities)
            {
                Edit(e);
            }
        }

        public T Find(ObjectId id)
        {
            return _collection.AsQueryable<T>().Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<T> FindAll()
        {
            return _collection.AsQueryable<T>().Where(x=>true);
        }
    }
}
