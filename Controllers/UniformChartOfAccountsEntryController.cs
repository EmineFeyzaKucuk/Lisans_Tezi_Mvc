using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.UniformChartOfAccountsEntryRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class UniformChartOfAccountsEntryController : Controller
    {

        private readonly IUniformChartOfAccountsEntryRepository _uniformChartOfAccountsEntryRepository;

        public UniformChartOfAccountsEntryController(IUniformChartOfAccountsEntryRepository uniformChartOfAccountsEntryRepository)
        {
            _uniformChartOfAccountsEntryRepository = uniformChartOfAccountsEntryRepository;
        }

        public IActionResult CreateUniformChartOfAccountsEntry(ACCOUNTING_UNIFORM_CHART_OF_ACCOUNTS_ENTRY uniformChartOfAccountsEntry)
        {

            if (uniformChartOfAccountsEntry.A_P == null)
            {
                uniformChartOfAccountsEntry.A_P = "false";
            }



            try
            {
                //  return Ok(uniformChartOfAccountsEntry);
                _uniformChartOfAccountsEntryRepository.Add(uniformChartOfAccountsEntry);
                return RedirectToAction("UniformChartOfAccountsEntry", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
    
    }
}
