using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.UniformChartOfAccountsEntryRepo;

namespace Lisans_Tezi_Mvc.Repository.AlternativeChartOfAccountsEntryRepo
{
    public class AlternativeChartOfAccountsEntryRepository : GenericRepository<ALTERNATIVE_CHART_OF_ACCOUNTS_ENTRY>, IAlternativeChartOfAccountsEntryRepository
    {
        public AlternativeChartOfAccountsEntryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public ALTERNATIVE_CHART_OF_ACCOUNTS_ENTRY GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
