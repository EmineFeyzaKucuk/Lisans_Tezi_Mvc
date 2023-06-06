using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.ProductionRecordRepo;

namespace Lisans_Tezi_Mvc.Repository.SafetyStockRepo
{
    public class SafetyStockRepository : GenericRepository<SAFETY_STOCK>, ISafetyStockRepository
    {
        public SafetyStockRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
