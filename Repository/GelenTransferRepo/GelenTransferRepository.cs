using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;

namespace Lisans_Tezi_Mvc.Repository.GelenTransferRepo
{
    public class GelenTransferRepository : GenericRepository<GELEN_TRANSFER>, IGelenTransferRepository
    {
        public GelenTransferRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
