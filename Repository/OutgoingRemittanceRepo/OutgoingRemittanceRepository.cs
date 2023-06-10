using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.OutgoingRemittanceRepo
{
    public class OutgoingRemittanceRepository : GenericRepository<OUTGOING_REMITTANCE>, IOutgoingRemittanceRepository
    {
        public OutgoingRemittanceRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
