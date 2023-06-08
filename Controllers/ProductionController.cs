using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.MadeOfDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.OperationDescriptionRepo;
using Lisans_Tezi_Mvc.Repository.OperatorDescriptionRepo;
using Lisans_Tezi_Mvc.Repository.OperatorTypesDescriptionRepo;
using Lisans_Tezi_Mvc.Repository.ProductGroupDefinitionsRepo;
using Lisans_Tezi_Mvc.Repository.ProductionOrderEntryRepo;
using Lisans_Tezi_Mvc.Repository.ProductionRecordRepo;
using Lisans_Tezi_Mvc.Repository.SafetyStockRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockCard2Repo;
using Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;
using Lisans_Tezi_Mvc.Repository.WaterFootPrintRepo;
using Lisans_Tezi_Mvc.Repository.WorkstationIdentificationRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductionController : Controller
    {
        private readonly IWaterFootPrintRepository _waterFootPrintRepository;
        private readonly IMachineIdentificationRepository _machineIdentificationRepository;
        private readonly IOperationDescriptionRepository _operationDescriptionRepository;
        private readonly IOperatorTypesDescriptionRepository _operatorTypesDescriptionRepository;
        private readonly IOperatorDescriptionRepository _operatorDescriptionRepository;
        private readonly IProductGroupDefinitionsRepository _productGroupDefinitionsRepository;
        private readonly IEmployeeDefinitionRepository _employeeDefinitionRepository;
        private readonly IUnitofMeasureDefinitionRepository _unitofMeasureDefinitionRepository;
        private readonly IStockInformationRepository _stockInformationRepository;
        private readonly ICurrentCardIdentificationRepository _currentCardIdentificationRepository;
        private readonly IProductionOrderEntryRepository _productionOrderEntryRepository;
        private readonly IMadeOfDefinitionRepository _madeOfDefinitionRepository;
        private readonly IWarehouseDefinitionRepository _warehouseDefinitionRepository;
        private readonly IProductionRecordRepository _productionRecordRepository;
        private readonly IWorkstationIdentificationRepository _workstationIdentificationRepository;
        private readonly ISafetyStockRepository _safetyStockRepository;

        public ProductionController(IMachineIdentificationRepository machineIdentificationRepository,IOperationDescriptionRepository operationDescriptionRepository, IOperatorTypesDescriptionRepository operatorTypesDescriptionRepository, IOperatorDescriptionRepository operatorDescriptionRepository, IProductGroupDefinitionsRepository productGroupDefinitionsRepository,IEmployeeDefinitionRepository employeeDefinitionRepository, IUnitofMeasureDefinitionRepository unitofMeasureDefinitionRepository, IStockInformationRepository stockInformationRepository , ICurrentCardIdentificationRepository currentCardIdentificationRepository, IProductionOrderEntryRepository productionOrderEntryRepository,IMadeOfDefinitionRepository madeOfDefinitionRepository, IWarehouseDefinitionRepository warehouseDefinitionRepository,IProductionRecordRepository productionRecordRepository,IWorkstationIdentificationRepository workstationIdentificationRepository,IWaterFootPrintRepository waterFootPrintRepository, ISafetyStockRepository safetyStockRepository)
        {
            _waterFootPrintRepository = waterFootPrintRepository;
            _machineIdentificationRepository = machineIdentificationRepository;
            _operationDescriptionRepository = operationDescriptionRepository;
            _operatorTypesDescriptionRepository = operatorTypesDescriptionRepository;
            _operatorDescriptionRepository = operatorDescriptionRepository;
            _productGroupDefinitionsRepository = productGroupDefinitionsRepository;
            _employeeDefinitionRepository = employeeDefinitionRepository;
            _unitofMeasureDefinitionRepository = unitofMeasureDefinitionRepository;
            _stockInformationRepository = stockInformationRepository;
            _currentCardIdentificationRepository = currentCardIdentificationRepository;
            _productionOrderEntryRepository = productionOrderEntryRepository;
            _madeOfDefinitionRepository = madeOfDefinitionRepository;
            _warehouseDefinitionRepository = warehouseDefinitionRepository;
            _productionRecordRepository = productionRecordRepository;
            _workstationIdentificationRepository = workstationIdentificationRepository;
            _safetyStockRepository = safetyStockRepository;
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
            //ViewBag.data1 = _machineIdentificationRepository.GetAll();

            MachineIdentification adc = new MachineIdentification();

            adc.getAllMachineIdentification();


            return View("~/Views/Production/MachineIdentification/MachineIdentification.cshtml",adc);
        }


        public IActionResult OperationDescription()
        {


            // ViewBag.data1 = _operationDescriptionRepository.GetAll();

            OperationDescription adc = new OperationDescription();

            adc.getAllOperationDescription();

            return View("~/Views/Production/OperationDescription/OperationDescription.cshtml",adc);
        }

        public IActionResult OperatorTypesDescription()
        {

            //ViewBag.data1 = _operatorTypesDescriptionRepository.GetAll();

            OperatorTypesDescription adc = new OperatorTypesDescription();

            adc.getAllOperatorTypesDescription();

            return View("~/Views/Production/OperatorTypesDescription/OperatorTypesDescription.cshtml",adc);
        }

        public IActionResult OperatorDescription()
        {
            ViewBag.data1 = _operatorTypesDescriptionRepository.GetAll();
            ViewBag.data2 = _operatorDescriptionRepository.GetAll();

            
            return View("~/Views/Production/OperatorDescription/OperatorDescription.cshtml");
        }

        public IActionResult ProductGroupDefinitions()
        {


            ViewBag.data1 = _productGroupDefinitionsRepository.GetAll();
            return View("~/Views/Production/ProductGroupDefinitions/ProductGroupDefinitions.cshtml" );
        }

        public IActionResult ProductionOrderEntry()
        {

            ViewBag.data1 = _employeeDefinitionRepository.GetAll();
            ViewBag.data2 = _currentCardIdentificationRepository.GetAll();
            ViewBag.data3 = _stockInformationRepository.GetAll();
            ViewBag.data4 = _unitofMeasureDefinitionRepository.GetAll();

            ViewBag.data5 = _productionOrderEntryRepository.GetAll();
 

            return View("~/Views/Production/ProductionOrderEntry/ProductionOrderEntry.cshtml");
        }

        public IActionResult ProductionRecord()
        {

            ViewBag.data1 = _productionOrderEntryRepository.GetAll();
            ViewBag.data2 = _madeOfDefinitionRepository.GetAll();
            ViewBag.data3 = _stockInformationRepository.GetAll();
            ViewBag.data4 = _unitofMeasureDefinitionRepository.GetAll();
            ViewBag.data5 = _warehouseDefinitionRepository.GetAll();
            ViewBag.data6 = _productionRecordRepository.GetAll();
            return View("~/Views/Production/ProductionRecord/ProductionRecord.cshtml");
        }

        public IActionResult WorkstationIdentification()
        {
            ViewBag.data1 = _operatorDescriptionRepository.GetAll();
            ViewBag.data2 = _machineIdentificationRepository.GetAll();
            ViewBag.data3 = _workstationIdentificationRepository.GetAll();
      
            return View("~/Views/Production/WorkstationIdentification/WorkstationIdentification.cshtml");
        }

        public IActionResult WaterFootPrint()
        {
            ViewBag.data3 = _waterFootPrintRepository.GetAll();
            return View("~/Views/Production/WaterFootPrint/WaterFootPrint.cshtml");
        }


        public IActionResult SafetyStock()
        {
            ViewBag.data3 = _safetyStockRepository.GetAll();
            return View("~/Views/Production/SafetyStock/SafetyStock.cshtml");
        }
    }
}
