using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockCard2Repo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockCard2Controller : Controller
    {


        private readonly IStockCard2Repository _stockCard2Repository;

        public StockCard2Controller(IStockCard2Repository stockCard2Repository)
        {
            _stockCard2Repository = stockCard2Repository;
        }
        public IActionResult StockCard2()
        {
            var data = _stockCard2Repository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/Stock/StockCardRecord/StockCard2.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult CreateStockCard2(STOCK_CARD2 stockCard2Repository)
        {
            try
            {
                // return Ok(stockCard2Repository);
                _stockCard2Repository.Add(stockCard2Repository);
                return RedirectToAction("StockCard2", "Stock");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }


    }
}
