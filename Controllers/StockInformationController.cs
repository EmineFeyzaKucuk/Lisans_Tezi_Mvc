using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class StockInformationController : Controller
    {
        private readonly IStockInformationRepository _stockInformationRepository;

        public StockInformationController( IStockInformationRepository stockInformationRepository)
        {
            _stockInformationRepository = stockInformationRepository;
        }
        public IActionResult Index()
        {
            var data  = _stockInformationRepository.GetAll();

            if (data.Count>0)
            {
                return View(data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(STOCK_INFORMATION stockInfo) {
            try
            {
                _stockInformationRepository.Add(stockInfo);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }
        
        }
        //public IActionResult GetAll()
        //{
        //    var data = _stockInformationRepository.GetAll();
        //    return PartialView("~/Views/Stock/StockCardRecords/_StockCodeList.cshtml", data);
        //}

    }
}
