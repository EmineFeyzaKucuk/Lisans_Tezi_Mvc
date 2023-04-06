using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;

namespace Lisans_Tezi_Mvc.Repository.StockCard1Repo
{
    public class StockCard1Repository : GenericRepository<STOCK_CARD1>, IStockCard1Repository
    {

        public StockCard1Repository(AppDbContext appDbContext): base(appDbContext) 
        {
            
        }


    }
}
