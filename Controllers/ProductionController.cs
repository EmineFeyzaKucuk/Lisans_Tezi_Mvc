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
        //ürün aşama

        public IActionResult ProductStages()
        {
            return View(" ~/Views/Production/ProductStages/ProductStages.cshtml");
        }
              public IActionResult MachineIdentification()
        {
            return View("~/Views/Production/MachineIdentification/MachineIdentification.cshtml");
        }


        public IActionResult OperationDescription()
        {
            return View("~/Views/Production/OperationDescription/OperationDescription.cshtml");
        }

        public IActionResult OperatorTypesDescription()
        {
            return View("~/Views/Production/OperatorTypesDescription/OperatorTypesDescription.cshtml");
        }

        public IActionResult ProductGroupDefinitions()
        {
            return View("~/Views/Production/ProductGroupDefinitions/ProductGroupDefinitions.cshtml" );
        }

        public IActionResult ProductionOrderEntry()
        {
            return View("~/Views/Production/ProductionOrderEntry/ProductionOrderEntry.cshtml");
        }

        public IActionResult ProductionRecord()
        {
            return View("~/Views/Production/ProductionRecord/ProductionRecord.cshtml");
        }

        public IActionResult WorkstationIdentification()
        {
            return View("~/Views/Production/WorkstationIdentification/WorkstationIdentification.cshtml");
        }

      
    }
}
