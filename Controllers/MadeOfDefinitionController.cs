using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MadeOfDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class MadeOfDefinitionController : Controller
    {
        private readonly IMadeOfDefinitionRepository _madeOfDefinitionRepository;

        public MadeOfDefinitionController(IMadeOfDefinitionRepository madeOfDefinitionRepository)
        {
            _madeOfDefinitionRepository = madeOfDefinitionRepository;
        }

        public IActionResult MadeOfDefinition()
        {
            var data = _madeOfDefinitionRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/GeneralOperations/Definitions/MadeOfDefinition.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(GENERAL_MADE_OF_DEFINITION madeOfDefinition)
        {
            try
            {
                _madeOfDefinitionRepository.Add(madeOfDefinition);
                return RedirectToAction("MadeOfDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
    }
}
