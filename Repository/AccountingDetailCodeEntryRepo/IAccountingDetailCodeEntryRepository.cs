using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo
{
    public interface IAccountingDetailCodeEntryRepository :IRepository<ACCOUNTING_DETAILCODE_ENTRY>
    {

        ACCOUNTING_DETAILCODE_ENTRY GetById(int id);
    }
}
