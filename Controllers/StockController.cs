using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockInformationRepository _stockInformationRepository;

        private readonly IStockCard1Repository _stockCard1Repository;

        public StockController(IStockInformationRepository stockInformationRepository, IStockCard1Repository stockCard1Repository)
        {
            _stockInformationRepository = stockInformationRepository;
            _stockCard1Repository = stockCard1Repository;
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
            var data = _stockInformationRepository.GetAll();
            return View("~/Views/Stock/StockCardRecords/StockCard1.cshtml",data);
        }

        public IActionResult AddStockCard1(STOCK_CARD1 stockCard1)
        {
            var stokkodu = _stockInformationRepository.GetByName(stockCard1.STOK_ADI);
            stockCard1.STOK_KODU = stokkodu.STOK_KODU;
            _stockCard1Repository.Add(stockCard1);
            return RedirectToAction("StockCard1");

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

        //DEPO İŞLEMLERİ
      

       public IActionResult Inter_WarehouseTransferReceipt()
        {
            return View("~/Views/Stock/WarehouseOperations/Inter_WarehouseTransferReceipt.cshtml");
        }
        public IActionResult WarehouseDefinition()
        {
            return View("~/Views/Stock/WarehouseOperations/WarehouseDefinition.cshtml");
        }
        //STOK FİYAT İŞLEMLERİ
        public IActionResult StockPrice()
        {
            return View("~/Views/Stock/StockPriceTransaction/StockPrice.cshtml");
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

