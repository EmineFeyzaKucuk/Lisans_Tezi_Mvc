using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CreditNoteRepo;
using Lisans_Tezi_Mvc.Repository.DebitMemoRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class CreditNoteController :Controller
    {

        private readonly ICreditNoteRepository _creditNoteRepository;

        public CreditNoteController(ICreditNoteRepository creditNoteRepository)
        {
            _creditNoteRepository = creditNoteRepository;
        }

        public IActionResult CreateDebitMemo(CREDIT_NOTE creditNote)
        {
            try
            {
                //  return Ok(uniformChartOfAccountsEntry);
                _creditNoteRepository.Add(creditNote);
                return RedirectToAction("CreditNote", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }
}
