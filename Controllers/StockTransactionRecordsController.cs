using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;

using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockTransactionRecordsController : Controller
    {

        private readonly IStockTransactionRecordsRepository _stockTransactionRecordsRepository;

        public StockTransactionRecordsController(IStockTransactionRecordsRepository stockTransactionRecordsRepository)
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
    }
}
