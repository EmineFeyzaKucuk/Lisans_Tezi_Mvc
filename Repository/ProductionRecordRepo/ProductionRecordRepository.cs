using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.ProductionOrderEntryRepo;

namespace Lisans_Tezi_Mvc.Repository.ProductionRecordRepo
{
    public class ProductionRecordRepository : GenericRepository<PRODUCTION_RECORD>, IProductionRecordRepository
    {
        public ProductionRecordRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }




    }
}
