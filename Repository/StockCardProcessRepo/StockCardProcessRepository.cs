using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.ProductionRecordRepo;

namespace Lisans_Tezi_Mvc.Repository.StockCardProcessRepo
{
    public class StockCardProcessRepository : GenericRepository<STOCK_CARD_PROCESS_Framework>, IStockCardProcessRepository
    {
        public StockCardProcessRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
