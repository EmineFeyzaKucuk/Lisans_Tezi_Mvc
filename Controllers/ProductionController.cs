using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductionController : Controller
    {



        public IActionResult Index()
        {
            return View();
        }

        //Reçete Kaydı sayfa 1

        public IActionResult PrescriptionRegistration()
        {
            return View("~/Views/Production/PrescriptionRegistration/PrescriptionRegistration.cshtml");
        }

    }
}
