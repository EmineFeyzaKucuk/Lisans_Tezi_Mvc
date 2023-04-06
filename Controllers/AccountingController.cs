using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AccountingController :Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        //STOK HAREKET KAYITLARI

        public IActionResult AccountingCodeDefinition()
        {
            return View("~/Views/Accounting/AccountingCodeDefinition/AccountingCodeDefinition.cshtml");
        }

    }
}
