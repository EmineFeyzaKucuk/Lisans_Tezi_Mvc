using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo
{
    public class AccountingDetailCodeEntryRepository : GenericRepository<ACCOUNTING_DETAILCODE_ENTRY>, IAccountingDetailCodeEntryRepository
    {
        public AccountingDetailCodeEntryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public ACCOUNTING_DETAILCODE_ENTRY GetById(int id)
        {
            var data1 = _appDbContext.MuhasebeDetayKodGiris_TBL.ToList();
            var detaykod = data1.First(x => x.MUHASEBE_KODU == id);
            return detaykod;
        }

      
        
    }
}
