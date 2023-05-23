using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.ProductionOrderEntryRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductionOrderEntryController: Controller
    {

        private readonly IProductionOrderEntryRepository _productionOrderEntryRepository;

        public ProductionOrderEntryController(IProductionOrderEntryRepository productionOrderEntryRepository)
        {
            _productionOrderEntryRepository = productionOrderEntryRepository;
        }

        public IActionResult CreateProductionOrderEntry(PRODUCTION_ORDER_ENTRY productionOrderEntry)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _productionOrderEntryRepository.Add(productionOrderEntry);
                return RedirectToAction("ProductionOrderEntry", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
    }
}
