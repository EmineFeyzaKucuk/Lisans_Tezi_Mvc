using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.ProductionRecordRepo;
using Lisans_Tezi_Mvc.Repository.WorkstationIdentificationRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class WorkstationIdentificationController :Controller
    {



        private readonly IWorkstationIdentificationRepository _workstationIdentificationRepository;

        public WorkstationIdentificationController(IWorkstationIdentificationRepository workstationIdentificationRepository)
        {
            _workstationIdentificationRepository = workstationIdentificationRepository;
        }

        public IActionResult CreateWorkstationIdentification(WORKSTATION_IDENTIFICATION workstationrecord)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _workstationIdentificationRepository.Add(workstationrecord);
                return RedirectToAction("WorkstationIdentification", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }


        public IActionResult WorkstationIdentificationEdit(int Id)
        {

            WorkstationIdentification str = new WorkstationIdentification();
            str.IstasyonBilgisiGetir();
            str.getWorkstationIdentification(Id);

            str.dt.Tables[0].TableName = "operator";
            str.dt.Tables[1].TableName = "makine";



            return View("~/Views/Production/WorkstationIdentification/WorkstationIdentification1.cshtml", str);

        }

        public IActionResult WorkstationIdentificationnew()
        {

            WorkstationIdentification str = new WorkstationIdentification();
            str.IstasyonBilgisiGetir();

            str.dt.Tables[0].TableName = "operator";
            str.dt.Tables[1].TableName = "makine";
           

            return View("~/Views/Production/WorkstationIdentification/WorkstationIdentification1.cshtml", str);


        }
        public IActionResult WorkstationIdentificationSave(WorkstationIdentification str)
        {
            WorkstationIdentification ste = new WorkstationIdentification();
            str.saveWorkstationIdentification(str);


            return Redirect("/Production/WorkstationIdentification");
        }

        public IActionResult WorkstationIdentificationDelete(WorkstationIdentification str)
        {
            WorkstationIdentification ste = new WorkstationIdentification();
            str.deleteWorkstationIdentification(str.ISTASYON_KODU);

            return Redirect("/Production/WorkstationIdentification");
        }





    }
}
