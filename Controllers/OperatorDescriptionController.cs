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


        public IActionResult OperatorDescriptionNew()
        {

            OperatorDescription str = new OperatorDescription();
            str.operasyonBilgisiGetir();




            str.dt.Tables[0].TableName = "operatorTkod";


            return View("~/Views/Production/OperatorDescription/OperatorDescription1.cshtml", str);


        }
        public IActionResult OperatorDescriptionSave(OperatorDescription str)
        {
            OperatorDescription ste = new OperatorDescription();
            str.saveOperatorDescription(str);


            return Redirect("/Production/OperatorDescription");
        }

        public IActionResult OperatorDescriptionDelete(OperatorDescription str)
        {
            OperatorDescription ste = new OperatorDescription();
            str.deleteOperatorDescription(str.OPERATOR_KODU);

            return Redirect("/Production/OperatorDescription");
        }

        public IActionResult OperatorDescriptionEdit(int Id)
        {

            OperatorDescription str = new OperatorDescription();
            str.operasyonBilgisiGetir();
            str.getOperatorDescription(Id);

            str.dt.Tables[0].TableName = "operatorTkod";



            return View("~/Views/Production/OperatorDescription/OperatorDescription1.cshtml", str);

        }
    }
}
