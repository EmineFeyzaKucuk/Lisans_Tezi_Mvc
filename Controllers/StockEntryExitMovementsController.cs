using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockEntryExitMovementsController :Controller
    {


        private readonly IStockEntryExitMovementsRepository _stockEntryExitMovementsRepository;

        public StockEntryExitMovementsController(IStockEntryExitMovementsRepository stockEntryExitMovementsRepository)
        {
            _stockEntryExitMovementsRepository = stockEntryExitMovementsRepository;
        }

        public IActionResult CreateStockEntryExitMovements(STOCK_IN_AND_OUT stock_in_and_out)
        {
            try
            {
               //  return Ok(stock_in_and_out);
                _stockEntryExitMovementsRepository.Add(stock_in_and_out);
                return RedirectToAction("StockEntryExitMovements", "Stock");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }


    }
}
