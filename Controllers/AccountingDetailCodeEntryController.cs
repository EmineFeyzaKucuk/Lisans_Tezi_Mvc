using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

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


        public IActionResult AcountingDetailCodeEdit(int muhasebeKodu)
        {

            Accounting_Detail_Code_Entry mdk = new Accounting_Detail_Code_Entry();
            mdk.StokMuhasebeBilgisiGetir();
            mdk.getAccountingDetailCodeEntry(muhasebeKodu);


            mdk.dt.Tables[0].TableName = "muhasebeKodlari";


            return View("~/Views/Stock/AccountingDetailCodeEntry/AccountingDetailCode.cshtml", mdk);

        }

        public IActionResult AccountingDetailCodeNew()
        {

            Accounting_Detail_Code_Entry mdk = new Accounting_Detail_Code_Entry();
            mdk.StokMuhasebeBilgisiGetir();
            //mdk.getAccountingDetailCodeEntry();

            mdk.dt.Tables[0].TableName = "muhasebeKodlari";

           

            return View("~/Views/Stock/AccountingDetailCodeEntry/AccountingDetailCode.cshtml", mdk); 


        }

        public IActionResult AccountingDetailCodeSave(Accounting_Detail_Code_Entry adc)
        {
            Accounting_Detail_Code_Entry ste = new Accounting_Detail_Code_Entry();
            adc.saveAccountingDetailCodeEntry(adc);

            //string a = JsonConvert.SerializeObject(stp, Formatting.Indented);
            //return Content(a);

            return Redirect("/Stock/AccountingDetailCodeEntry");
        }


        public IActionResult AccountingDetailCodeDelete(Accounting_Detail_Code_Entry adc)
        {
            Accounting_Detail_Code_Entry ste = new Accounting_Detail_Code_Entry();
            adc.deleteAccountingDetailCodeEntry(adc.MUHASEBE_KODU);

            return Redirect("/ Stock / AccountingDetailCodeEntry");
        }







        //public IActionResult deleteAccountingDetailCodeEntry(Accounting_Detail_Code_Entry accounting_Detail_Code_Entry)
        //{
        //    Accounting_Detail_Code_Entry ac = new Accounting_Detail_Code_Entry();

        //    ac.deleteAccountingDetailCodeEntry(accounting_Detail_Code_Entry.MUHASEBE_KODU);


        //    return RedirectToAction("AccountingDetailCodeEntry", "Stock");
        //}


    }
}
