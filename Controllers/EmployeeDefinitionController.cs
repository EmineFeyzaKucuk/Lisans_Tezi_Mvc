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
            EmployeeDefinition adc = new EmployeeDefinition();

            adc.getAllEmployeeDefinition();

            return View("~/Views/Stock/EmployeeDefinition/EmployeeDefinition.cshtml",adc);
           
        }

        public IActionResult EmployeeDefinitionNew()
        {

            EmployeeDefinition ste = new EmployeeDefinition();
            ste.PersonelBilgisi();


            ste.dt.Tables[0].TableName = "personel";



            return View("~/Views/Stock/EmployeeDefinition/EmployeeDefinition1.cshtml", ste);


        }
        public IActionResult EmployeeDefinitionSave(EmployeeDefinition sbk)
        {
            EmployeeDefinition ste = new Models.EmployeeDefinition();
            sbk.saveEmployeeDefinition(sbk);

           

            return Redirect("/EmployeeDefinition/EmployeeDefinition");
        }

        public IActionResult EmployeeDefinitionDelete(EmployeeDefinition sbk)
        {
            EmployeeDefinition ste = new EmployeeDefinition();
            sbk.deleteEmployeeDefinition(sbk.Id);

            return Redirect("/EmployeeDefinition/EmployeeDefinition");
        }


        public IActionResult EmployeeDefinitionEdit(int Id)
        {

            EmployeeDefinition ste = new EmployeeDefinition();
            ste.PersonelBilgisi();
            ste.getEmployeeDefinition(Id);

            ste.dt.Tables[0].TableName = "personel";




            return View("~/Views/Stock/EmployeeDefinition/EmployeeDefinition1.cshtml", ste);

        }





        //        public IActionResult Add(EMPLOYEE_DEFINITION employeeDefinitionRepository)
        //        {
        //            try
        //            {
        //                _employeeDefinitionRepository.Add(employeeDefinitionRepository);
        //                return RedirectToAction("EmployeeDefinition");
        //            }
        //            catch (Exception)
        //            {

        //                return BadRequest("Eklenemedi");
        //            }

        //        }






    }
}
