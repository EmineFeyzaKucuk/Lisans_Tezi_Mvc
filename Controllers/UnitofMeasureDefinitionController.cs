using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class UnitofMeasureDefinitionController :Controller
    {
        private readonly IUnitofMeasureDefinitionRepository _unitofMeasureDefinitionRepository;

        public UnitofMeasureDefinitionController(IUnitofMeasureDefinitionRepository unitofMeasureDefinitionRepository)
        {
            _unitofMeasureDefinitionRepository = unitofMeasureDefinitionRepository;
        }

        public IActionResult UnitofMeasureDefinition()
        {
            var data = _unitofMeasureDefinitionRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/GeneralOperations/Definitions/UnitofMeasureDefinition.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(GENERAL_MEASUREMENT_UNIT unitofMeasureDefinition)
        {
            try
            {
                _unitofMeasureDefinitionRepository.Add(unitofMeasureDefinition);
                return RedirectToAction("UnitofMeasureDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
    }
}
