using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;
using Microsoft.AspNetCore.Mvc;

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
                return RedirectToAction("WarehouseTransferReceipt", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }



}
