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
        public IActionResult OperatorTypesDescriptionNew()
        {

            OperatorTypesDescription str = new OperatorTypesDescription();
            str.operatorTurBilgisiGetir();




            str.dt.Tables[0].TableName = "opreratorTur";


            return View("~/Views/Production/OperatorTypesDescription/OperatorTypesDescription1.cshtml", str);
           

        }
        public IActionResult OperatorTypesDescriptionSave(OperatorTypesDescription str)
        {
            OperatorTypesDescription ste = new OperatorTypesDescription();
            str.saveOperatorTypesDescription(str);


            return Redirect("/Production/OperatorTypesDescription");
        }
        public IActionResult OperatorTypesDescriptionDelete(OperatorTypesDescription str)
        {
            OperatorTypesDescription ste = new OperatorTypesDescription();
            str.deleteOperatorTypesDescription(str.OPERATOR_TUR_KODU);

            return Redirect("/Production/OperatorTypesDescription");
        }

        public IActionResult OperatorTypesDescriptionEdit(int Id)
        {

            OperatorTypesDescription str = new OperatorTypesDescription();
            str.operatorTurBilgisiGetir();
            str.getOperatorTypesDescription(Id);

            str.dt.Tables[0].TableName = "opreratorTur";



            return View("~/Views/Production/OperatorTypesDescription/OperatorTypesDescription1.cshtml", str);

        }

        



    }
}
