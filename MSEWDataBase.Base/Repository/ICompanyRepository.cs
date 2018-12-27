using MSEWDataBase.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Base.Repository
{
    public interface ICompanyRepository:IRepository<Company>
    {
        Company GetByName(string name);
    }
}
