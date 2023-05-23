using Microsoft.AspNetCore.Mvc;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AccountingController :Controller
    {
        private readonly ICurrencyDefinitionRepository _currencyDefinitionRepository;


        public AccountingController( ICurrencyDefinitionRepository currencyDefinitionRepository)
        {
            _currencyDefinitionRepository = currencyDefinitionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        //STOK HAREKET KAYITLARI

        public IActionResult AccountingCodeDefinition()
        {
            return View("~/Views/Accounting/AccountingCodeDefinition/AccountingCodeDefinition.cshtml");
        }

        //Cari kart tanımlama

        public IActionResult CurrentCardIdentification()
        {
            var data = _currencyDefinitionRepository.GetAll();
            return View("~/Views/Accounting/CurrentCardIdentification/CurrentCardIdentification.cshtml",data);
        }


        public IActionResult UniformChartOfAccountsEntry()
        {
            return View("~/Views/Accounting/UniformChartOfAccountsEntry/UniformChartOfAccountsEntry.cshtml");
        }

        public IActionResult OffsetReceiptEntry()
        {
            return View("~/Views/Accounting/OffsetReceiptEntry/OffsetReceiptEntry.cshtml");
        }


        public IActionResult IncomingTransfer()
        {
            return View("~/Views/Accounting/IncomingTransfer/IncomingTransfer.cshtml");
        }

        public IActionResult OutgoingRemittance()
        {
            return View("~/Views/Accounting/OutgoingRemittance/OutgoingRemittance.cshtml");
        }


        public IActionResult AlternativeChartOfAccountsEntry()
        {
            return View("~/Views/Accounting/AlternativeChartOfAccountsEntry/AlternativeChartOfAccountsEntry.cshtml");
        }


        public IActionResult CreditNote()
        {
            return View("~/Views/Accounting/CreditNote/CreditNote.cshtml");
        }

        public IActionResult CurrentTransferVir()
        {
            return View("~/Views/Accounting/CurrentTransferVir/CurrentTransferVir.cshtml");
        }

        public IActionResult DebitMemo()
        {
            return View("~/Views/Accounting/DebitMemo/DebitMemo.cshtml");
        }


    }
}
