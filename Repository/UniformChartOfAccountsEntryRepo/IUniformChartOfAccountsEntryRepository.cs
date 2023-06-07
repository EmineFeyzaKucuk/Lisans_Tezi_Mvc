using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.UniformChartOfAccountsEntryRepo
{
    public interface IUniformChartOfAccountsEntryRepository : IRepository<ACCOUNTING_UNIFORM_CHART_OF_ACCOUNTS_ENTRY>
    {



        ACCOUNTING_UNIFORM_CHART_OF_ACCOUNTS_ENTRY GetByName(string name);
        ACCOUNTING_UNIFORM_CHART_OF_ACCOUNTS_ENTRY GetById(int id);


    }
}
