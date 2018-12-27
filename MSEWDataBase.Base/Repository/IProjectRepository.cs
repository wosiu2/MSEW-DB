using MongoDB.Bson;
using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Base.Repository
{
    public interface IProjectRepository
    {

        IEnumerable<Project> GetByYear(string year);
        IEnumerable<Project> GetByName(string name);
        IEnumerable<Project> GetByCompany(Company company);
        IEnumerable<Project> GetByCountry(string country);

        IEnumerable<Project> GetByInvolved(Person person);
        IEnumerable<Project> GetByMainDesigner(Person designer);
    }
}
