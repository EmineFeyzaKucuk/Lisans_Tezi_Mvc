using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AccountingCodeDefinitionController : Controller
    {

        private readonly IAccountingCodeDefinitionRepository _accountingCodeDefinitionRepository;

        public AccountingCodeDefinitionController(IAccountingCodeDefinitionRepository accountingCodeDefinitionRepository)
        {
            _accountingCodeDefinitionRepository = accountingCodeDefinitionRepository;
        }
        public IActionResult AccountingCodeDefinition()
        {
            var data = _accountingCodeDefinitionRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/Accounting/AccountingCodeDefinition/AccountingCodeDefinition.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(ACCOUNTING_CODE_DEFINITION accountingCodeDefinition)
        {
            try
            {
                _accountingCodeDefinitionRepository.Add(accountingCodeDefinition);
                return RedirectToAction("AccountingCodeDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
     


    }
}
