using MongoDB.Bson;
using MongoDB.Driver;
using MSEWDataBase.Base.Model;
using MSEWDataBase.Base.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Repository
{
    public class CalculationRepository:BaseRepository<Calculation>,ICalculationRepository
    {
        public CalculationRepository(IMongoClient client, string dbName = "MSEWDB") : base(client, dbName) { }

        public IEnumerable<Calculation> GetByDesigner(Person designer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculation> GetByLoadModel(string loadModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculation> GetByProjectId(ObjectId projectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Calculation> GetByWallHeight(double height)
        {
            throw new NotImplementedException();
        }
    }
}
