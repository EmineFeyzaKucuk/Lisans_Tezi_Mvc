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
               //   return Ok(accountingCodeDefinition);
                _accountingCodeDefinitionRepository.Add(accountingCodeDefinition);
                return RedirectToAction("AccountingCodeDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

        [HttpDelete]
        public IActionResult DeleteAccountingCodeDefinition(int id)
        {
            try
            {
               
                _accountingCodeDefinitionRepository.Delete(id);
                return RedirectToAction("AccountingCodeDefinition");
            }
            catch (Exception)
            {

                return BadRequest("silinemedi");
            }
        }

        public IActionResult EditAccountingCodeDefinition()
        {
            var id = Convert.ToInt32(Request.Query["id"]);
            TempData["id"] = id;
            ACCOUNTING_CODE_DEFINITION gelen = _accountingCodeDefinitionRepository.GetById(id);
            return View("~/Views/Accounting/AccountingCodeDefinition/EditAccountingCodeDefinition.cshtml", gelen);
        }
        public IActionResult UpdateAccountingCodeDefinition(ACCOUNTING_CODE_DEFINITION  editAccounting)
        {
            int id = Convert.ToInt32(TempData["id"]);
            ACCOUNTING_CODE_DEFINITION gelen = _accountingCodeDefinitionRepository.GetById(id);
            gelen.MUHASEBE_KODU = editAccounting.MUHASEBE_KODU;
            gelen.MUHASEBE_ADI = editAccounting.MUHASEBE_ADI;
            _accountingCodeDefinitionRepository.Update(gelen, id);
            return RedirectToAction("AccountingCodeDefinition");


        }
    }
}
