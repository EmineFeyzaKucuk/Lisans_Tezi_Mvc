using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;

namespace Lisans_Tezi_Mvc.Repository.WaterFootPrintRepo
{
    public class WaterFootPrintRepository : GenericRepository<WATER_FOOTPRINT>, IWaterFootPrintRepository
    {
        public WaterFootPrintRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public WATER_FOOTPRINT GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }



}
