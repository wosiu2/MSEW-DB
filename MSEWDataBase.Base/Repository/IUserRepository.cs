using MSEWDataBase.Base.Enum;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;

namespace MSEWDataBase.Base.Repository
{
    public interface IUserRepository:IRepository<User>
    {

        IEnumerable<User> GetByFirstName(string firstName);
        IEnumerable<User> GetByLastName(string lastName);
        User GetByLogin(string login);
        IEnumerable<User> GetByRole(Privileges privileges);
    }
}
