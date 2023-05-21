using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class MachineIdentificationController : Controller
    {

            private readonly IMachineIdentificationRepository _machineIdentificationRepository;

            public MachineIdentificationController(IMachineIdentificationRepository machineIdentificationRepository)
            {
            _machineIdentificationRepository = machineIdentificationRepository;
            }

            public IActionResult CreateMachineIdentification(MACHINE_IDENTIFICATION machine_identification)
            {
                try
                {
                //  return Ok(stock_in_and_out);
                _machineIdentificationRepository.Add(machine_identification);
                    return RedirectToAction("MachineIdentification", "Production");
                }
                catch (Exception)
                {

                    return BadRequest("Eklenemedi");
                }

            }




    }
}
