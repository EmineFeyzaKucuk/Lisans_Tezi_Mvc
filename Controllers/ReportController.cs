using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ReportController: Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        //STOK HAREKET KAYITLARI

        public IActionResult StockTransactionRecordsReport()
        {
            return View("~/Views/Report/StockTransactionRecordsReport/StockTransactionRecordsReport.cshtml");
        }


        public IActionResult StockLatestStatusList()
        {
            return View("~/Views/Report/StockLatestStatusList/StockLatestStatusList.cshtml");
        }
    }
}
