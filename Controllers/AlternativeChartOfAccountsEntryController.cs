using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AlternativeChartOfAccountsEntryRepo;
using Lisans_Tezi_Mvc.Repository.UniformChartOfAccountsEntryRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class AlternativeChartOfAccountsEntryController :Controller
    {



        private readonly IAlternativeChartOfAccountsEntryRepository _alternativeChartOfAccountsEntryRepository;

        public AlternativeChartOfAccountsEntryController(IAlternativeChartOfAccountsEntryRepository alternativeChartOfAccountsEntryRepository)
        {
            _alternativeChartOfAccountsEntryRepository = alternativeChartOfAccountsEntryRepository;
        }

        public IActionResult CreateAlternativeChartOfAccountsEntry(ALTERNATIVE_CHART_OF_ACCOUNTS_ENTRY alternativeChartOfAccountsEntry)
        {
            try
            {
                //  return Ok(uniformChartOfAccountsEntry);
                _alternativeChartOfAccountsEntryRepository.Add(alternativeChartOfAccountsEntry);
                return RedirectToAction("AlternativeChartOfAccountsEntry", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }












    }
}
