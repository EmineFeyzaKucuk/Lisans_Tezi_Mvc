using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.DebitMemoRepo;
using Lisans_Tezi_Mvc.Repository.OutgoingRemittanceRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class OutgoingRemittanceController : Controller
    {
        private readonly IOutgoingRemittanceRepository _outgoingRemittanceRepository;

        public OutgoingRemittanceController(IOutgoingRemittanceRepository outgoingRemittanceRepository)
        {
            _outgoingRemittanceRepository = outgoingRemittanceRepository;
        }

        public IActionResult CreateOutgoingRemittance(OUTGOING_REMITTANCE outgoingRemittance)
        {
            try
            {
                // return Ok(debitMemo);
                _outgoingRemittanceRepository.Add(outgoingRemittance);
                return RedirectToAction("OutgoingRemittance", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }
}
