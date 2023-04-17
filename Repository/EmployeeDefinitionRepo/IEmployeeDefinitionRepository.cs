using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository;

namespace Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo
{
    public interface IEmployeeDefinitionRepository : IRepository<EMPLOYEE_DEFINITION>
    {

        EMPLOYEE_DEFINITION GetByName(string name);


    }
}


