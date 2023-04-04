using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.StockInformationRepo
{
    public class StockInformationRepository:GenericRepository<STOCK_INFORMATION>, IStockInformationRepository
    {
        //Farklı bişey getirceğinde ilk interface sonra burası

        //public void GetByStockInfoName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        public StockInformationRepository(AppDbContext appDbContext):base(appDbContext) 
        {
            
        }

      

    }
}
