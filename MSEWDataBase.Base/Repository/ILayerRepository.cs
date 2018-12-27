using MongoDB.Bson;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;

namespace MSEWDataBase.Base.Repository
{
    public interface ILayerRepository:IRepository<Layer>
    {
        IEnumerable<Layer> FindByCalculationId(ObjectId calculationId);
    }
}
