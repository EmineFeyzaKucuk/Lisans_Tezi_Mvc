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





    }
}
