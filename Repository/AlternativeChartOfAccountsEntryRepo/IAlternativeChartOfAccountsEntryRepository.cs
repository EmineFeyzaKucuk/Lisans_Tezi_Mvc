using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.AlternativeChartOfAccountsEntryRepo
{
    public interface IAlternativeChartOfAccountsEntryRepository : IRepository<ALTERNATIVE_CHART_OF_ACCOUNTS_ENTRY>
    {

        ALTERNATIVE_CHART_OF_ACCOUNTS_ENTRY GetByName(string name);
        ALTERNATIVE_CHART_OF_ACCOUNTS_ENTRY GetById(int id);

    }
}
