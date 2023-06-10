using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.GelenTransferRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class GelenTransferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IGelenTransferRepository _gelenTransferRepository;

        public GelenTransferController(IGelenTransferRepository gelenTransferRepository)
        {
            _gelenTransferRepository = gelenTransferRepository;
        }

        public IActionResult CreateGelenTransfer(GELEN_TRANSFER gelenTransfer)
        {
            try
            {
              //  return Ok(gelenTransfer);
                _gelenTransferRepository.Add(gelenTransfer);
                return RedirectToAction("GelenTransfer", "Accounting");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }
        }
    }

}
