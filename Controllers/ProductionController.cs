using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockCard2Repo;
using Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductionController : Controller
    {
        private readonly IMachineIdentificationRepository _machineIdentificationRepository;

        public ProductionController(IMachineIdentificationRepository machineIdentificationRepository)
        {

            _machineIdentificationRepository = machineIdentificationRepository;
        }


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
            return View("~/Views/Production/ProductStages/ProductStages.cshtml");
        }


              public IActionResult MachineIdentification()
        {
            ViewBag.data1 = _machineIdentificationRepository.GetAll();

            
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

        public IActionResult OperatorDescription()
        {
            return View("~/Views/Production/OperatorDescription/OperatorDescription.cshtml");
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
