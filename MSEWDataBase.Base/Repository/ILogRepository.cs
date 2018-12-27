using MSEWDataBase.Base.Model;
using System.Collections.Generic;


namespace MSEWDataBase.Base.Repository
{
    public interface ILogRepository:IRepository<Log>
    {
        IEnumerable<Log> GetByUser(User user);

    }
}
