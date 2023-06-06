using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.SafetyStockRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class SafetyStockController : Controller

    {

        private readonly ISafetyStockRepository _safetyStockRepository;

        public SafetyStockController(ISafetyStockRepository safetyStockRepository)
        {
        _safetyStockRepository = safetyStockRepository;
        }

        public IActionResult CreateSafetyStock(SAFETY_STOCK safetyStock)
        {
        try
        {
                //  return Ok(stock_in_and_out);
                _safetyStockRepository.Add(safetyStock);
            return RedirectToAction("SafetyStock", "Production");
        }
        catch (Exception)
        {

            return BadRequest("Eklenemedi");
        }

    }
    }
}
