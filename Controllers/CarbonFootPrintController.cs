using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CarbonFootprintRepo;
using Lisans_Tezi_Mvc.Repository.WaterFootPrintRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class CarbonFootPrintController :Controller
    {

        private readonly ICarbonFootprintRepository _carbonFootprintRepository;

        public CarbonFootPrintController(ICarbonFootprintRepository carbonFootprintRepository)
        {
            _carbonFootprintRepository = carbonFootprintRepository;
        }

        public IActionResult CreateCarbonFootPrint(CARBON_FOOTPRINT carbonFootPrint)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _carbonFootprintRepository.Add(carbonFootPrint);
                return RedirectToAction("CarbonFootPrint", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }
}
