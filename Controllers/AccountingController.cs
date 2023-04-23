using Microsoft.AspNetCore.Mvc;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;

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

    }
}
