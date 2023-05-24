using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class GeneralOperationsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //Barkod Tip tanımlama

        public IActionResult BarcodeTypeDefinition()
        {
            return View("~/Views/GeneralOperations/Definitions/BarcodeTypeDefinition.cshtml");
        }

        //Para Birimi tanımlama

        public IActionResult CurrencyDefinition()
        {

            return View("~/Views/GeneralOperations/Definitions/CurrencyDefinition.cshtml");
        }

        //Tip Tanımlama

        public IActionResult MadeOfDefinition()
        {

            return View("~/Views/GeneralOperations/Definitions/MadeOfDefinition.cshtml");
        }
        //Ölçü Birimi Tanımlama

        public IActionResult UnitofMeasureDefinition()
        {

            return View("~/Views/GeneralOperations/Definitions/UnitofMeasureDefinition.cshtml");
        }


    }
}
