using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using System.Xml.Linq;

namespace Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo
{
    public class BarcodeRecordsRepository : GenericRepository<BARCODE_RECORDS>, IBarcodeRecordsRepository
    {
        public BarcodeRecordsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public STOCK_INFORMATION GetByName(string name)
        {
            var data1 = _appDbContext.StokBilgisi_TBL.ToList();
            var stokKodu = data1.First(x => x.STOK_ADI == name);
            return stokKodu;
        }


        public GENERAL_BARCODE_TYPE_DEFINITION GetByName2(string name)
        {
            var data1 = _appDbContext.Genel_BarkodTipiTanimlama_TBL.ToList();
            var stokKodu = data1.First(x => x.BARKOD_TIPI == name);
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
