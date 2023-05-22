using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.OperationDescriptionRepo;
using Lisans_Tezi_Mvc.Repository.OperatorTypesDescriptionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class OperatorTypesDescriptionController :Controller
    {
        private readonly IOperatorTypesDescriptionRepository _operatorTypesDescriptionRepository;

        public OperatorTypesDescriptionController(IOperatorTypesDescriptionRepository operatorTypesDescriptionRepository)
        {
            _operatorTypesDescriptionRepository = operatorTypesDescriptionRepository;
        }
        public IActionResult CreateOperatorTypesDescription(OPERATOR_TYPES_DESCRIPTION operatorTypesDescription)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _operatorTypesDescriptionRepository.Add(operatorTypesDescription);
                return RedirectToAction("OperatorTypesDescription", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }
        }
    }
}
