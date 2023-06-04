using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AccountingDetailCodeEntryController : Controller
    {


        private readonly IAccountingDetailCodeEntryRepository _accountingDetailCodeEntryRepository;

        public AccountingDetailCodeEntryController(IAccountingDetailCodeEntryRepository accountingDetailCodeEntryRepository)
        {
            _accountingDetailCodeEntryRepository = accountingDetailCodeEntryRepository;
        }

        public IActionResult CreateAccountingDetilCodeControllerDefinition(ACCOUNTING_DETAILCODE_ENTRY accountingDetailCodeEntry)
        {
            try
            {
                 //return Ok(accountingDetailCodeEntry);
                _accountingDetailCodeEntryRepository.Add(accountingDetailCodeEntry);
                return RedirectToAction("AccountingDetailCodeEntry", "Stock");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
        //public IActionResult AccountingCodeDelete()
        //{
        //    int muhasebeKodu = Convert.ToInt32(Request.Form["MUHASEBE_KODU"].ToString());


        //    _accountingDetailCodeEntryRepository.Delete(muhasebeKodu);

        //    return RedirectToAction("AccountingDetailCodeEntry", "Stock");
        //}

        public IActionResult deleteAccountingDetailCodeEntry(Accounting_Detail_Code_Entry accounting_Detail_Code_Entry)
        {
            Accounting_Detail_Code_Entry ac = new Accounting_Detail_Code_Entry();

            ac.deleteAccountingDetailCodeEntry(accounting_Detail_Code_Entry.MUHASEBE_KODU);


            return RedirectToAction("AccountingDetailCodeEntry", "Stock");
        }


    }
}
