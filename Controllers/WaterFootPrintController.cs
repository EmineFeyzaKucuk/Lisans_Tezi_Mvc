using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WaterFootPrintRepo;
using Lisans_Tezi_Mvc.Repository.WorkstationIdentificationRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class WaterFootPrintController :Controller
    {

        private readonly IWaterFootPrintRepository _waterFootPrintRepository;

        public WaterFootPrintController(IWaterFootPrintRepository waterFootPrintRepository)
        {
            _waterFootPrintRepository = waterFootPrintRepository;
        }

        public IActionResult CreateWaterFootPrint(WATER_FOOTPRINT waterFootPrint)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _waterFootPrintRepository.Add(waterFootPrint);
                return RedirectToAction("WaterFootPrint", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }










    }
}
