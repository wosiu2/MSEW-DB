using MongoDB.Bson;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;


namespace MSEWDataBase.Base.Repository
{
    public interface IStripLoadRepository:IRepository<StripLoad>
    {
        IEnumerable<StripLoad> GetByCalculationId(ObjectId calculationId);
    }
}
