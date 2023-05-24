using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class WarehouseDefinitionController : Controller
    {

        private readonly IWarehouseDefinitionRepository _warehouseDefinitionRepository;

        public WarehouseDefinitionController(IWarehouseDefinitionRepository warehouseDefinitionRepository)
        {
            _warehouseDefinitionRepository = warehouseDefinitionRepository;
        }
   
        public IActionResult CreateWarehouseDefinition(WAREHOUSE_DEFINITION warehouseDefinitionRepository)
        {
            try
            {
              //  return Ok(warehouseDefinitionRepository);
                _warehouseDefinitionRepository.Add(warehouseDefinitionRepository);
                return RedirectToAction("WarehouseDefinition","Stock");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
        public IActionResult WarehouseDefinitionDelete()
        {
            int depoKodu = Convert.ToInt32(Request.Form["DEPO_KODU_LBL"].ToString());


            _warehouseDefinitionRepository.Delete(depoKodu);

            return RedirectToAction("WareHouseDefinition", "Stock");
        }





    }
}






