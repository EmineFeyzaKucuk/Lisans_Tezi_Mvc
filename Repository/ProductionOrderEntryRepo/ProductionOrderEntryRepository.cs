using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;

namespace Lisans_Tezi_Mvc.Repository.ProductionOrderEntryRepo
{
    public class ProductionOrderEntryRepository : GenericRepository<PRODUCTION_ORDER_ENTRY>, IProductionOrderEntryRepository
    {
        public ProductionOrderEntryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }


        public STOCK_INFORMATION GetByName(string name)
        {
            var data1 = _appDbContext.StokBilgisi_TBL.ToList();
            var stokKodu = data1.First(x => x.STOK_ADI == name);
            return stokKodu;
        }

        public GENERAL_MEASUREMENT_UNIT GetByName3(string name)
        {



            var data3 = _appDbContext.Genel_OlcuBirimiTanimlama_TBL.ToList();
            var olcuBirimiKodu = data3.First(x => x.OLCU_BIRIMI_KODU == name);
            return olcuBirimiKodu;
        }

    }
}
