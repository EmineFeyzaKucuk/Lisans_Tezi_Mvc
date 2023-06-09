using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AlternativeChartOfAccountsEntryRepo;
using Lisans_Tezi_Mvc.Repository.DebitMemoRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class DebitMemoController :Controller
    {

        private readonly IDebitMemoRepository _debitMemoRepository;

        public DebitMemoController(IDebitMemoRepository debitMemoRepository)
        {
            _debitMemoRepository = debitMemoRepository;
        }

        public IActionResult CreateDebitMemo(DEBIT_MEMO debitMemo)
        {
            try
            {
                //  return Ok(uniformChartOfAccountsEntry);
                _debitMemoRepository.Add(debitMemo);
                return RedirectToAction("DebitMemo", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }
    }
}
