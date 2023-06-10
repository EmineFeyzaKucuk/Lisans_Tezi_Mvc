using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrentTransferVirRepo;
using Lisans_Tezi_Mvc.Repository.DebitMemoRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class CurrentTransferVirController : Controller
    {


        private readonly ICurrentTransferVirRepository _currentTransferVirRepository;

        public CurrentTransferVirController(ICurrentTransferVirRepository currentTransferVirRepository)
        {
            _currentTransferVirRepository = currentTransferVirRepository;
        }

        public IActionResult CreateCurrentTransferVir(ACCOUNTING_CURRENT_TRANSFER_VIR currentTransferVir)
        {
            try
            {
               //  return Ok(currentTransferVir);
                _currentTransferVirRepository.Add(currentTransferVir);
                return RedirectToAction("CurrentTransferVir", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }
}
