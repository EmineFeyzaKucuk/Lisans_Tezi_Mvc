using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository;

namespace Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo
{
    public class EmployeeDefinitionRepository : GenericRepository<EMPLOYEE_DEFINITION>, IEmployeeDefinitionRepository
    {
        public EmployeeDefinitionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }


        public EMPLOYEE_DEFINITION GetByName(string name)
        {
            var data = _appDbContext.Personel_TBL.ToList();
            var employeeDefinition = data.First(x => x.PERSONEL_ISIM == name);
            return employeeDefinition;
        }
    }
}


