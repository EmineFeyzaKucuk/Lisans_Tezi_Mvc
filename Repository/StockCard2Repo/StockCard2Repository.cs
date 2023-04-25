using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.StockCard2Repo
{
    public class StockCard2Repository : GenericRepository<STOCK_CARD2>, IStockCard2Repository
    {
        public StockCard2Repository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        

        public STOCK_INFORMATION GetByName(string name)
        {
            var data1 = _appDbContext.StokBilgisi_TBL.ToList();
            var stokKodu = data1.First(x => x.STOK_ADI == name);
            return stokKodu ;
        }


        public ACCOUNTING_CURRENT_CARD_DEFINITION GetByName2(string name)
        {
            var data2 = _appDbContext.Muhasebe_CariKartTanimlama_TBL.ToList();
            var cariKodu = data2.First(x => x.UNVAN == name);
            return cariKodu;
        }


        
    public GENERAL_MEASUREMENT_UNIT GetByName3(string name)
        {
            var data3 = _appDbContext.Genel_OlcuBirimiTanimlama_TBL.ToList();
            var olcuBirimiKodu = data3.First(x => x.OLCU_BIRIMI_KODU == name);
            return olcuBirimiKodu;
        }

    }
}
