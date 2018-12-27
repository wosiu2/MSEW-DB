using MSEWDataBase.Base.Enum;
using MSEWDataBase.Base.Model;
using System.Collections.Generic;


namespace MSEWDataBase.Base.Repository
{
    public interface IPersonRepository:IRepository<Person>
    {
        IEnumerable<Person> GetByFirstName(string firstName);
        IEnumerable<Person> GetByLastName(string lastName);
        IEnumerable<Person> GetByPhone(string lastName);
        IEnumerable<Person> GetByEmail(string lastName);
        IEnumerable<Person> GetByPosition(Positions position);
    }
}
