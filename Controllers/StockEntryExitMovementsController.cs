using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

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

        public IActionResult StockEntriyExitMovementsDelete(STOCK_IN_AND_OUT stock_in_and_out)
        {
            int stokKodu = Convert.ToInt32(Request.Form["STOK_KODU"].ToString());


            _stockEntryExitMovementsRepository.Delete(stokKodu);

            return RedirectToAction("StockEntryExitMovements", "Stock");
        }

        //public IActionResult StockEntriyExitMovementsDelete(STOCK_IN_AND_OUT stock_in_and_out)
        //{
        //    StockCardProcess ste = new StockCardProcess();
        //    ste.deleteStockCard(stock_in_and_out.Id);

        //    return Redirect("/StockEntriyExitMovements");
        //}





    }
}
