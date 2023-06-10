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

        public IActionResult MachineıdentificationNew()
        {

            MachineIdentification str = new MachineIdentification();
            str.makineBilgisiGetir();
            



            str.dt.Tables[0].TableName = "makine";
            

            return View("~/Views/Production/MachineIdentification/MachineIdentification1.cshtml", str);
            // return Content("burasır55rrrrrrrrr");

        }
        public IActionResult MachineIdentificationSave(MachineIdentification str)
        {
            MachineIdentification ste = new MachineIdentification();
            str.saveMachineIdentification(str);

           
            return Redirect("/Production/MachineIdentification");
        }
        public IActionResult MachineIdentificationDelete(MachineIdentification str)
        {
            MachineIdentification ste = new MachineIdentification();
            str.deleteMachineIdentification(str.MAKINE_KODU);

            return Redirect("/Production/MachineIdentification");
        }

        public IActionResult MachineIdentificationEdit(int Id)
        {

            MachineIdentification str = new MachineIdentification();
            str.makineBilgisiGetir();
            str.getMachineIdentification(Id);

            str.dt.Tables[0].TableName = "makine";



            return View("~/Views/Production/MachineIdentification/MachineIdentification1.cshtml", str);

        }





    }
}
