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

        public STOCK_INFORMATION GetByName(string name)
        {
           var data = _appDbContext.StokBilgisi_TBL.ToList();
            var stockinfo = data.First(x=>x.STOK_ADI == name);
            return stockinfo;
        }
    }
}
