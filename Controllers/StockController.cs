using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockCard2Repo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockInformationRepository _stockInformationRepository;

        private readonly IStockCard1Repository _stockCard1Repository;
        private readonly IEmployeeDefinitionRepository _employeeDefinitionRepository;
        private readonly IWarehouseDefinitionRepository _warehouseDefinitionRepository;
        private readonly IStockCard2Repository _stockCard2Repository;
        private readonly ICurrentCardIdentificationRepository _currentCardIdentificationRepository;
 
        private readonly IUnitofMeasureDefinitionRepository _unitofMeasureDefinitionRepository;
        private readonly IStockTransactionRecordsRepository _stockTransactionRecordsRepository;
        private readonly IGroupCodeRecordsRepository _groupCodeRecordsRepository;
        private readonly IAccountingDetailCodeEntryRepository _accountingDetailCodeEntryRepository;
        private readonly IAccountingCodeDefinitionRepository _accountingCodeDefinitionRepository;

        public StockController(IStockInformationRepository stockInformationRepository, IStockCard1Repository stockCard1Repository,IEmployeeDefinitionRepository employeeDefinitionRepository,IWarehouseDefinitionRepository warehouseDefinitionRepository,    IStockCard2Repository stockCard2Repository, ICurrentCardIdentificationRepository currentCardIdentificationRepository, IUnitofMeasureDefinitionRepository unitofMeasureDefinitionRepository, IStockTransactionRecordsRepository stockTransactionRecordsRepository, IGroupCodeRecordsRepository groupCodeRecordsRepository , IAccountingDetailCodeEntryRepository accountingDetailCodeEntryRepository, IAccountingCodeDefinitionRepository accountingCodeDefinitionRepository)
        {
        
            _stockInformationRepository = stockInformationRepository;
            _stockCard1Repository = stockCard1Repository;
            _employeeDefinitionRepository = employeeDefinitionRepository;
            _warehouseDefinitionRepository = warehouseDefinitionRepository;
            _stockCard2Repository = stockCard2Repository;
            _currentCardIdentificationRepository = currentCardIdentificationRepository;
            _unitofMeasureDefinitionRepository = unitofMeasureDefinitionRepository;
            _stockTransactionRecordsRepository = stockTransactionRecordsRepository;
            _groupCodeRecordsRepository = groupCodeRecordsRepository;
            _accountingDetailCodeEntryRepository = accountingDetailCodeEntryRepository;
            _accountingCodeDefinitionRepository = accountingCodeDefinitionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        //STOCK CARD RECORDS
        public IActionResult StockDefinition()
        {
            return View("~/Views/Stock/StockCardRecords/StockDefinition.cshtml");
        }

        public IActionResult StockCard1()
        {
            ViewBag.data1 = _stockInformationRepository.GetAll();
            ViewBag.data2 = _warehouseDefinitionRepository.GetAll();
            return View("~/Views/Stock/StockCardRecords/StockCard1.cshtml");
        }

        public IActionResult AddStockCard1(STOCK_CARD1 stockCard1)
        {
            var depokodu = _warehouseDefinitionRepository.GetById(stockCard1.DEPO_KODU);
            stockCard1.DEPO_KODU = depokodu.DEPO_KODU;

            var stokkodu = _stockInformationRepository.GetByName(stockCard1.STOK_ADI);
            stockCard1.STOK_KODU = stokkodu.STOK_KODU;
            _stockCard1Repository.Add(stockCard1);
            return RedirectToAction("StockCard1");

        }

        public IActionResult StockCard2()
        {

            ViewBag.data1 = _stockInformationRepository.GetAll();
            ViewBag.data2 = _currentCardIdentificationRepository.GetAll();
            ViewBag.data3 = _unitofMeasureDefinitionRepository.GetAll();
            return View("~/Views/Stock/StockCardRecords/StockCard2.cshtml");
        }
        public IActionResult StockPriceTransaction()
        {
            return View("~/Views/Stock/StockCardRecords/StockPriceTransaction.cshtml");
        }
        
        public IActionResult StockInfo()
        {
            return View("~/Views/Stock/StockCardRecords/StockInfo.cshtml");
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

            ViewBag.data1 = _stockInformationRepository.GetAll();
            ViewBag.data2 = _warehouseDefinitionRepository.GetAll();
            ViewBag.data3 = _stockTransactionRecordsRepository.GetAll(); 

            return View("~/Views/Stock/StockTransactionRecords/stockTransactionRecords.cshtml");
        }

        //Stock Kod Kayıtları

        public IActionResult GroupCodeRecords()
        {

            ViewBag.data1 = _groupCodeRecordsRepository.GetAll();
            return View("~/Views/Stock/StockCodeRecords/GroupCodeRecords.cshtml");
        }

        public IActionResult Stock_GroupCodeDefine()
        {
            return View("~/Views/Stock/StockCodeRecords/Stock_GroupCodeDefine.cshtml");
        }
    
        public IActionResult AccountingDetailCodeEntry()
        {

            ViewBag.data1 = _accountingCodeDefinitionRepository.GetAll();
            ViewBag.data2 = _accountingCodeDefinitionRepository.GetAll();
            ViewBag.data3 = _accountingCodeDefinitionRepository.GetAll();
            ViewBag.data4 = _accountingCodeDefinitionRepository.GetAll();
            ViewBag.data5 = _accountingCodeDefinitionRepository.GetAll();
            ViewBag.data6= _accountingDetailCodeEntryRepository.GetAll();
        

            return View("~/Views/Stock/AccountingDetailCodeEntry/AccountingDetailCodeEntry.cshtml");
        }
        //BARKOD KAYITLARI

        public IActionResult BarcodeRecords()
        {
            return View("~/Views/Stock/BarcodeRecords/BarcodeRecords.cshtml");
        }

        //DEPO İŞLEMLERİ
      

       public IActionResult Inter_WarehouseTransferReceipt()
        {
            return View("~/Views/Stock/WarehouseOperations/Inter_WarehouseTransferReceipt.cshtml");
        }
        public IActionResult WarehouseDefinition()
        {
            ViewBag.data1 = _warehouseDefinitionRepository.GetAll();
            ViewBag.data2 = _employeeDefinitionRepository.GetAll();
            return View("~/Views/Stock/WarehouseOperations/WarehouseDefinition.cshtml");
        }
        
     

        //STOK GİRİŞ ÇIKIŞ HAREKETLERİ
        public IActionResult StockEntryExitMovements()
        {
            return View("~/Views/Stock/StockEntryExitMovements/StockEntryExitMovements.cshtml");
        }
        //PERSONEL TANIMLAMA
        public IActionResult EmployeeDefinition()
        {
            return View("~/Views/Stock/EmployeeDefinition/EmployeeDefinition.cshtml");
        }
        //RİSKLİ MALZEME GRUBU TANIMLAMA
              public IActionResult RiskyMaterialGroupDefinition()
        {
            return View("~/Views/Stock/RiskyMaterialGroupDefinition/RiskyMaterialGroupDefinition.cshtml");
        }

  

    }

}

