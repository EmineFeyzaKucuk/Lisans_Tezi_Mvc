using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AccountingCurrentCardIdentificationController:Controller
    {



        private readonly ICurrentCardIdentificationRepository _currentCardIdentificationRepository;
        private readonly ICurrencyDefinitionRepository _currencyDefinitionRepository;

        public AccountingCurrentCardIdentificationController(ICurrentCardIdentificationRepository currentCardIdentificationRepository)
        {
            _currentCardIdentificationRepository = currentCardIdentificationRepository;

      
        }
        public IActionResult CurrentCardIdentification()
        {
            var data = _currentCardIdentificationRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/Accounting/CurrentCardIdentification/CurrentCardIdentification.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult CreateAccountingCurrentCardDefinition(ACCOUNTING_CURRENT_CARD_DEFINITION currentCardIdentificationRepository)
        {
            try
            {
                //  return Ok(warehouseDefinitionRepository);
                _currentCardIdentificationRepository.Add(currentCardIdentificationRepository);
                return RedirectToAction("CurrentCardIdentification", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }











    }
}
