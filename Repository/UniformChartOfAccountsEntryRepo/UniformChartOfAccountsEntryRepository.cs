using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.UniformChartOfAccountsEntryRepo
{
    public class UniformChartOfAccountsEntryRepository : GenericRepository<ACCOUNTING_UNIFORM_CHART_OF_ACCOUNTS_ENTRY>, IUniformChartOfAccountsEntryRepository
    {
        public UniformChartOfAccountsEntryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public ACCOUNTING_UNIFORM_CHART_OF_ACCOUNTS_ENTRY GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
