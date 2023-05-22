using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.OperationDescriptionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class OperationDescriptionController :Controller
    {



        private readonly IOperationDescriptionRepository _operationDescriptionRepository;

        public OperationDescriptionController(IOperationDescriptionRepository operationDescriptionRepository)
        {
            _operationDescriptionRepository = operationDescriptionRepository;
        }

        public IActionResult CreateOperationDescription(OPERATION_DESCRIPTION operationDescription)
        {
            try
            {
              
                //  return Ok(stock_in_and_out);
                _operationDescriptionRepository.Add(operationDescription);
                return RedirectToAction("OperationDescription", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }


    }
}
