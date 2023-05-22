using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.OperatorDescriptionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class OperatorDescriptionController :Controller
    {
            private readonly IOperatorDescriptionRepository _operatorDescriptionRepository;

            public OperatorDescriptionController(IOperatorDescriptionRepository operatorDescriptionRepository)
            {
            _operatorDescriptionRepository = operatorDescriptionRepository;
            }

            public IActionResult CreateOperatorDescription(OPERATOR_DESCRIPTION operatorDescription)
            {
                try
                {
                //  return Ok(stock_in_and_out);
                _operatorDescriptionRepository.Add(operatorDescription);
                    return RedirectToAction("OperatorDescription", "Production");
                }
                catch (Exception)
                {

                    return BadRequest("Eklenemedi");
                }

            }
        }
}
