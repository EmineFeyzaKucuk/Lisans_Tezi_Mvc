using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class BarcodeRecordsController :Controller
    {

        private readonly IBarcodeRecordsRepository _barcodeRecordsRepository;

        public BarcodeRecordsController(IBarcodeRecordsRepository barcodeRecordsRepository)
        {
            _barcodeRecordsRepository = barcodeRecordsRepository;
        }

        public IActionResult CreateBarcodeRecords(BARCODE_RECORDS barcodeRecords)
        {
            try
            {
             //   return Ok(barcodeRecords);
                _barcodeRecordsRepository.Add(barcodeRecords);
                return RedirectToAction("BarcodeRecords", "Stock");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
        public ActionResult BarcodeRecordsDelete() 
        {
            int stokKodu = Convert.ToInt32(Request.Form["STOK_KODU"].ToString());


            _barcodeRecordsRepository.Delete(stokKodu);

            return RedirectToAction("BarcodeRecords", "Stock");

        }



    }
}
