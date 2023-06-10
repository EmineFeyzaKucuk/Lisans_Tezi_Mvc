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


        public IActionResult BarcodeRecordsNew()
        {

            BarcodeRecords sbk = new BarcodeRecords();
            sbk.barkodBilgisiGetir();


            sbk.dt.Tables[0].TableName = "Stokkodları";
            sbk.dt.Tables[1].TableName = "barkod";
            sbk.dt.Tables[2].TableName = "olcuBirimi";

            return View("~/Views/Stock/BarcodeRecords/BarcodeRecords1.cshtml", sbk);
            // return Content("burasır55rrrrrrrrr");

        }
        public IActionResult BarcodeRecordsSave(BarcodeRecords sbk)
        {
            BarcodeRecords ste = new BarcodeRecords();
            sbk.saveBarcodeRecords(sbk);

            //string a = JsonConvert.SerializeObject(stp, Formatting.Indented);
            //return Content(a);

            return Redirect("/Stock/BarcodeRecords");
        }
        public IActionResult BarcodeRecordsDelete(BarcodeRecords sbk)
        {
            BarcodeRecords ste = new BarcodeRecords();
            sbk.deleteBarcodeRecords(sbk.STOK_KODU);

            return Redirect("/Stock/BarcodeRecords");
        }

        public IActionResult BarcodeRecordsEdit(string stokkodu)
        {

            BarcodeRecords ste = new BarcodeRecords();
            ste.barkodBilgisiGetir();
            ste.getBarcodeRecords(stokkodu);

            ste.dt.Tables[0].TableName = "Stokkodları";
            ste.dt.Tables[1].TableName = "barkod";
            ste.dt.Tables[2].TableName = "olcuBirimi";
           


            return View("~/Views/Stock/BarcodeRecords/BarcodeRecords1.cshtml", ste);

        }














        //public ActionResult BarcodeRecordsDelete() 
        //{
        //    int stokKodu = Convert.ToInt32(Request.Form["STOK_KODU"].ToString());


        //    _barcodeRecordsRepository.Delete(stokKodu);

        //    return RedirectToAction("BarcodeRecords", "Stock");

        //}



    }
}
