using MongoDB.Bson;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;

namespace MSEWDataBase.Base.Repository
{
    public interface ICalculationRepository:IRepository<Calculation>
    {
        IEnumerable<Calculation> GetByProjectId(ObjectId projectId);
        IEnumerable<Calculation> GetByDesigner(Person designer);
    }
}
