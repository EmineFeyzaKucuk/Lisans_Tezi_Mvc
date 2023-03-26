using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        //STOCK CARD RECORDS

        public IActionResult StockCard1()
        {
            return View("~/Views/Stock/StockCardRecords/StockCard1.cshtml");
        }
    
        public IActionResult StockCard2()
        {
            return View("~/Views/Stock/StockCardRecords/StockCard2.cshtml");
        }
        public IActionResult StockInfo()
        {
            return View("~/Views/Stock/StockCardRecords/StockInfo.cshtml");
        }
        public IActionResult Price()
        {
            return View("~/Views/Stock/StockCardRecords/Price.cshtml");
        }
       
       
        public IActionResult LocalWarehouseBalance()
        {
            return View("~/Views/Stock/StockCardRecords/LocalWarehouseBalance.cshtml");
        }
        public IActionResult PriceInfo()
        {
            return View("~/Views/Stock/StockCardRecords/PriceInfo.cshtml");
        }

        public IActionResult PrescriptionInfo()
        {
            return View("~/Views/Stock/StockCardRecords/PrescriptionInfo.cshtml");
        }
       
        //Stock Hareket Kayıtları

        public IActionResult stockTransactionRecords()
        {
            return View("~/Views/Stock/StockTransactionRecords/stockTransactionRecords.cshtml");
        }

        //Stock Kod Kayıtları

        public IActionResult GroupCodeRecords()
        {
            return View("~/Views/Stock/StockCodeRecords/GroupCodeRecords.cshtml");
        }
     
        public IActionResult Stock_GroupCodeDefine()
        {
            return View("~/Views/Stock/StockCodeRecords/Stock_GroupCodeDefine.cshtml");
        }
        public IActionResult StockMeasurePrice()
        {
            return View("~/Views/Stock/StockCodeRecords/StockMeasurePrice.cshtml");
        }
        public IActionResult AccountingDetailCodeEntry()
        {
            return View("~/Views/Stock/AccountingDetailCodeEntry/AccountingDetailCodeEntry.cshtml");
        }
        //BARKOD KAYITLARI

        public IActionResult BarcodeRecords()
        {
            return View("~/Views/Stock/BarcodeRecords/BarcodeRecords.cshtml");
        }



    }

}

