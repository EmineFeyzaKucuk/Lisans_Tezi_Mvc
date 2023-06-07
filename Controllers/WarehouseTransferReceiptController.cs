using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.Arm;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class WarehouseTransferReceiptController :Controller
    {



        private readonly IWarehouseTransferReceiptRepository _warehouseTransferReceiptRepository;

        public WarehouseTransferReceiptController(IWarehouseTransferReceiptRepository warehouseTransferReceiptRepository)
        {
            _warehouseTransferReceiptRepository = warehouseTransferReceiptRepository;
        }

        public IActionResult CreateWarehouseTransferReceipt(WAREHOUSE_TRANSFER_RECEIPT warhouseTransferReceipt)
        {
            try
            {
               //  return Ok(warhouseTransferReceipt);
                _warehouseTransferReceiptRepository.Add(warhouseTransferReceipt);
                return RedirectToAction("WarehouseTransferReceipt", "Stock");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }


        public IActionResult WarehouseTransferReceiptnew()
        {

            WarewhouseTransferReceipt dp = new WarewhouseTransferReceipt();
            dp.depoTransferBilgisi();
            dp.getStockTransactionRecordsCode();

            dp.dt.Tables[0].TableName = "depo";
            dp.dt.Tables[1].TableName = "stokkodlari";
            dp.dt.Tables[2].TableName = "olcu";


            return View("~/Views/Stock/WarehouseOperations/WarehouseTransferReceipt1.cshtml", dp);


        }

        public IActionResult WarehouseTransferReceiptSave(WarewhouseTransferReceipt dp)
        {
            WarewhouseTransferReceipt ste = new WarewhouseTransferReceipt();
            dp.saveWarehouseTransferReceipt(dp);

            //string a = JsonConvert.SerializeObject(stp, Formatting.Indented);
            //return Content(a);

            return Redirect("/Stock/WarehouseOperation/WarehouseTransferReceipt");
        }

        public IActionResult WarehouseTransferReceiptDelete(WarewhouseTransferReceipt dp)
        {
            WarewhouseTransferReceipt ste = new WarewhouseTransferReceipt();
            dp.deleteWarehouseTransferReceipt(dp.FIS_NO);

            return Redirect("/Stock/WarehouseTransferReceipt");
        }

        public IActionResult WarehouseTransferReceiptEdit(string fısNo)
        {

            WarewhouseTransferReceipt ste = new WarewhouseTransferReceipt();
            ste.depoTransferBilgisi();
            ste.getWarehouseTransferReceiptCode(fısNo);


            ste.dt.Tables[0].TableName = "depo";
            ste.dt.Tables[1].TableName = "stokkodlari";
            ste.dt.Tables[2].TableName = "olcu";



            return View("~/Views/Stock/WarehouseOperations/WarehouseTransferReceipt1.cshtml", ste);

        }




    }



}
