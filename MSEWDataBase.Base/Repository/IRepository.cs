using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace MSEWDataBase.Base.Repository
{
    public interface IRepository<T> where T:class
    {

        IEnumerable<T> FindAll();
        T Find(ObjectId id);
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        void Edit(T entity);
        void Edit(IEnumerable<T> entities);
    }
}
