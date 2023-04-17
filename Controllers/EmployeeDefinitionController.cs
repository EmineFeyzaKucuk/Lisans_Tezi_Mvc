using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class EmployeeDefinitionController : Controller
    {




        private readonly IEmployeeDefinitionRepository _employeeDefinitionRepository;

        public EmployeeDefinitionController(IEmployeeDefinitionRepository employeeDefinitionRepository)
        {
            _employeeDefinitionRepository = employeeDefinitionRepository;
        }
        public IActionResult EmployeeDefinition()
        {
            var data = _employeeDefinitionRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/Stock/EmployeeDefinition/EmployeeDefinition.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(EMPLOYEE_DEFINITION employeeDefinitionRepository)
        {
            try
            {
                _employeeDefinitionRepository.Add(employeeDefinitionRepository);
                return RedirectToAction("EmployeeDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }






    }
}
