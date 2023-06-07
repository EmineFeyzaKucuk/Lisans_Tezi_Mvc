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

        public IActionResult StockInAndOutNew()
        {

            StockInAndOut ste = new StockInAndOut();
            ste.depoTransferBilgisi();
            ste.getStockInAndOutCode();

            ste.dt.Tables[0].TableName = "depo";
            ste.dt.Tables[1].TableName = "stok";
            ste.dt.Tables[2].TableName = "olcu";
          

            return View("~/Views/Stock/StockEntryExitMovements/StockEntryExitMovements1.cshtml", ste);


        }
        public IActionResult StockInAndOutSave(StockInAndOut stp) 
        {
            StockInAndOut ste = new StockInAndOut();
            ste.saveStockInAndOut(stp);

            //string a = JsonConvert.SerializeObject(stp, Formatting.Indented);
            //return Content(a);

            return Redirect("/Stock/StockTransactionRecords");
        }


        public IActionResult StockInAndOutDelete(StockInAndOut stp)
        {
            StockInAndOut ste = new StockInAndOut();
            ste.deleteStockInAndOut(stp.FIS_NO);

            return Redirect("/Stock/StockTransactionRecords");
        }

        public IActionResult StockEntryExitMovementsEdit(string fısKodu)
        {

            StockInAndOut ste = new StockInAndOut();
            ste.depoTransferBilgisi();
            ste.getStockInAndOut(fısKodu);

            ste.dt.Tables[0].TableName = "depo";
            ste.dt.Tables[1].TableName = "stok";
            ste.dt.Tables[2].TableName = "olcu";




            return View("~/Views/Stock/StockEntryExitmovements/StockEntryExitmovements1.cshtml", ste);

        }





    }
}
