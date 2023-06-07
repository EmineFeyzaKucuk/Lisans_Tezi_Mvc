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


        public IActionResult WarehouseDefinitionnew()
        {

            WarehouseDefinition dp = new WarehouseDefinition();
            dp.DepoBilgisiGetir();
            



            dp.dt.Tables[0].TableName = "personel";
            

            return View("~/Views/Stock/WarehouseOperations/WarehouseDefinition1.cshtml", dp);
           

        }
        public IActionResult WarehouseDefinitionSave(WarehouseDefinition dp)
        {
            WarehouseDefinition ste = new WarehouseDefinition();
            dp.saveWarehouseDefinition(dp);

            //string a = JsonConvert.SerializeObject(stp, Formatting.Indented);
            //return Content(a);

            return Redirect("/Stock/WarehouseOperation/WarehouseDefinition");
        }
        public IActionResult WarehouseDefinitionDelete(WarehouseDefinition dp)
        {
            WarehouseDefinition ste = new WarehouseDefinition();
            dp.deleteWarehouseDefinition(dp.DEPO_KODU);

            return Redirect("/Stock/WarehouseDefinition");
        }

        public IActionResult WarehouseDefinitionEdit(int depokodu)
        {

            WarehouseDefinition ste = new WarehouseDefinition();
            ste.DepoBilgisiGetir();
            ste.getWarehouseDefinition(depokodu);

            ste.dt.Tables[0].TableName = "personel";
            



            return View("~/Views/Stock/WarehouseOperations/WarehouseDefinition1.cshtml", ste);

        }




        //public IActionResult WarehouseDefinitionDelete()
        //{
        //    int depoKodu = Convert.ToInt32(Request.Form["DEPO_KODU_LBL"].ToString());


        //    _warehouseDefinitionRepository.Delete(depoKodu);

        //    return RedirectToAction("WareHouseDefinition", "Stock");
        //}





    }
}






