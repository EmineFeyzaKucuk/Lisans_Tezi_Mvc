﻿using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;

namespace Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo
{
    public class StockEntryExitMovementsRepository : GenericRepository<STOCK_IN_AND_OUT>, IStockEntryExitMovementsRepository
    {
        public StockEntryExitMovementsRepository(AppDbContext appDbContext) : base(appDbContext)
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
            var data1 = _appDbContext.DepoTanimlama_TBL.ToList();
            var depokodu = data1.First(x => x.DEPO_KODU == id);
            return depokodu;
        }



        public GENERAL_MEASUREMENT_UNIT GetByName3(string name)
        {
            var data3 = _appDbContext.Genel_OlcuBirimiTanimlama_TBL.ToList();
            var olcuBirimiKodu = data3.First(x => x.OLCU_BIRIMI_KODU == name);
            return olcuBirimiKodu;
        }

        STOCK_IN_AND_OUT IStockEntryExitMovementsRepository.GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
