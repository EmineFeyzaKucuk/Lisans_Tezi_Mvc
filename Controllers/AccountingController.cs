using Microsoft.AspNetCore.Mvc;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.UniformChartOfAccountsEntryRepo;
using Lisans_Tezi_Mvc.Repository.AlternativeChartOfAccountsEntryRepo;
using Lisans_Tezi_Mvc.Repository.CreditNoteRepo;
using Lisans_Tezi_Mvc.Repository.DebitMemoRepo;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AccountingController :Controller
    {
        private readonly ICurrentCardIdentificationRepository _currentCardIdentificationRepository;
        private readonly ICurrencyDefinitionRepository _currencyDefinitionRepository;
        private readonly IUniformChartOfAccountsEntryRepository _uniformChartOfAccountsEntryRepository;
        private readonly IAlternativeChartOfAccountsEntryRepository _alternativeChartOfAccountsEntryRepository;
        private readonly IDebitMemoRepository _debitMemoRepository;
        private readonly ICreditNoteRepository _creditNoteRepository;
        private readonly AlternativeChartOfAccountsEntryController _alternativeChartOfAccountsEntry;

        public AccountingController(ICurrencyDefinitionRepository currencyDefinitionRepository, ICurrentCardIdentificationRepository currentCardIdentificationRepository, IUniformChartOfAccountsEntryRepository uniformChartOfAccountsEntryRepository, IAlternativeChartOfAccountsEntryRepository alternativeChartOfAccountsEntryRepository, IDebitMemoRepository debitMemoRepository, ICreditNoteRepository creditNoteRepository)
        {
            _currentCardIdentificationRepository = currentCardIdentificationRepository;
            _currencyDefinitionRepository = currencyDefinitionRepository;
            _uniformChartOfAccountsEntryRepository = uniformChartOfAccountsEntryRepository;
            _alternativeChartOfAccountsEntryRepository = alternativeChartOfAccountsEntryRepository;
            _debitMemoRepository = debitMemoRepository;
            _creditNoteRepository = creditNoteRepository;
            {
            }

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
            ViewBag.data1 = _currencyDefinitionRepository.GetAll();
            ViewBag.data2 = _currentCardIdentificationRepository.GetAll();
            return View("~/Views/Accounting/CurrentCardIdentification/CurrentCardIdentification.cshtml");
        }


        public IActionResult UniformChartOfAccountsEntry()
        {
            ViewBag.data1 = _uniformChartOfAccountsEntryRepository.GetAll();
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

            ViewBag.data1 = _alternativeChartOfAccountsEntryRepository.GetAll();
            
            return View("~/Views/Accounting/AlternativeChartOfAccountsEntry/AlternativeChartOfAccountsEntry.cshtml");
        }


        public IActionResult CreditNote()
        {
            ViewBag.data1 = _creditNoteRepository.GetAll();
            return View("~/Views/Accounting/CreditNote/CreditNote.cshtml");
        }

        public IActionResult CurrentTransferVir()
        {
            return View("~/Views/Accounting/CurrentTransferVir/CurrentTransferVir.cshtml");
        }

        public IActionResult DebitMemo()
        {
            ViewBag.data1 = _debitMemoRepository.GetAll();
            return View("~/Views/Accounting/DebitMemo/DebitMemo.cshtml");
        }


    }
}
