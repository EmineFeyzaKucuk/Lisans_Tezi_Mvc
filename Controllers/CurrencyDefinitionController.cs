using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class CurrencyDefinitionController : Controller
    {

        private readonly ICurrencyDefinitionRepository _currencyDefinitionRepository;


        public CurrencyDefinitionController(ICurrencyDefinitionRepository currencyDefinitionRepository)
        {
            _currencyDefinitionRepository = currencyDefinitionRepository;
        }

        public IActionResult CurrencyDefinition()
        {
            var data = _currencyDefinitionRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/GeneralOperations/Definitions/CurrencyDefinition.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(GENERAL_CURRENCY_DEFINITION currencyDefinition)
        {
            try
            {
                _currencyDefinitionRepository.Add(currencyDefinition);
                return RedirectToAction("CurrencyDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }










    }
}
