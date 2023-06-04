using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo
{
    public class StockTransactionRecordsRepository : GenericRepository<STOCK_TRANSACTION_RECORDS_ENTRY>, IStockTransactionRecordsRepository
    {
        public StockTransactionRecordsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public STOCK_INFORMATION GetByName(string name)
        {
            var data1 = _appDbContext.StokBilgisi_TBL.ToList();
            var stokKodu = data1.First(x => x.STOK_ADI == name);
            return stokKodu;
        }
        public WAREHOUSE_DEFINITION GetById(int id)
        {
            var data2 = _appDbContext.DepoTanimlama_TBL.ToList();
            var warehouseefinition2 = data2.First(x => x.DEPO_KODU == id);
            return warehouseefinition2;


        }


    }
}
