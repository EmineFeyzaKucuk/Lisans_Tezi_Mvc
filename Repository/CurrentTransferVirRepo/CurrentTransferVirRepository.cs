using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CreditNoteRepo;

namespace Lisans_Tezi_Mvc.Repository.CurrentTransferVirRepo
{
    public class CurrentTransferVirRepository : GenericRepository<ACCOUNTING_CURRENT_TRANSFER_VIR>, ICurrentTransferVirRepository
    {
        public CurrentTransferVirRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
