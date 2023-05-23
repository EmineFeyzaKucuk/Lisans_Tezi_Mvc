using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.ProductionOrderEntryRepo;
using Lisans_Tezi_Mvc.Repository.ProductionRecordRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductionRecordController : Controller
    {

        private readonly IProductionRecordRepository _productionRecordRepository;

        public ProductionRecordController(IProductionRecordRepository productionRecordRepository)
        {
            _productionRecordRepository = productionRecordRepository;
        }

        public IActionResult CreateProductionRecord(PRODUCTION_RECORD productionrecord)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _productionRecordRepository.Add(productionrecord);
                return RedirectToAction("ProductionRecord", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }
}
