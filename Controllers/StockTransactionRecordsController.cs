using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockTransactionRecordsController : Controller
    {

       private readonly IStockTransactionRecordsRepository _stockTransactionRecordsRepository;

        public  StockTransactionRecordsController(IStockTransactionRecordsRepository stockTransactionRecordsRepository)
        {
            _stockTransactionRecordsRepository = stockTransactionRecordsRepository;
        }





        public IActionResult CreateStockTransactionRecords(STOCK_TRANSACTION_RECORDS_ENTRY stockTransactionRecordsRepository)
        {
            try
            {
                //  return Ok(warehouseDefinitionRepository);
                _stockTransactionRecordsRepository.Add(stockTransactionRecordsRepository);
                return RedirectToAction("StockTransactionRecords", "Stock");
            }
             catch (Exception)
            {
               
               return BadRequest("Eklenemedi");
            }
            

        }
        public IActionResult StockTransactionEdit(int stokId)
        {

            StockTransactionRecords1 str = new StockTransactionRecords1();
            str.stokHareketBilgiGetir();
            str.getStockTransactionRecords(stokId);

            str.dt.Tables[0].TableName = "Stokkodları";
            str.dt.Tables[1].TableName = "depolar";



            return View("~/Views/Stock/StockTransactionRecords/StockTransactionRecordsnew.cshtml", str);

        }

        public IActionResult StockTransactionRecordsnew()
        {

            StockTransactionRecords1 str = new StockTransactionRecords1();
            str.stokHareketBilgiGetir();
            str.getStockTransactionRecordsCode();



            str.dt.Tables[0].TableName = "Stokkodları";
            str.dt.Tables[1].TableName = "depolar";

            return View("~/Views/Stock/StockTransactionRecords/StockTransactionRecordsnew.cshtml", str);
            // return Content("burasır55rrrrrrrrr");

        }
        public IActionResult StockTransactionSave(StockTransactionRecords1 str)
        {
            StockTransactionRecords1 ste = new StockTransactionRecords1();
            str.saveStockTransactionRecords(str);

            //string a = JsonConvert.SerializeObject(stp, Formatting.Indented);
            //return Content(a);

            return Redirect("/Stock/StockTransactionRecords");
        }

        public IActionResult StockTransactionDelete(StockTransactionRecords1 str) 
        {
            StockTransactionRecords1 ste = new StockTransactionRecords1();
            str.deleteStockTransactionRecords(str.STOK_KODU);

            return Redirect("/Stock/StockTransactionRecords");
        }







        //public IActionResult deleteStockTransactionRecords(StockTransactionRecords1 stockTransactionRecordsRepository)
        //{
        //    StockTransactionRecords1 st = new StockTransactionRecords1();
            
        //    st.deleteStockTransactionRecords(stockTransactionRecordsRepository.STOK_KODU);
            

        //    return RedirectToAction("StockTransactionRecords" , "Stock");
        //}




    }
}
