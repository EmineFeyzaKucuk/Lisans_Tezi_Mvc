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

        public IActionResult OperationDescriptionNew()
        {

            OperationDescription str = new OperationDescription();
            str.operasyonBilgisiGetir();




            str.dt.Tables[0].TableName = "operasyon";


            return View("~/Views/Production/OperationDescription/OperationDescription1.cshtml", str);
            

        }
        public IActionResult OperationDescriptionSave(OperationDescription str)
        {
            OperationDescription ste = new OperationDescription();
            str.saveOperationDescription(str);


            return Redirect("/Production/OperationDescription");
        }

        public IActionResult OperationDescriptionDelete(OperationDescription str)
        {
            OperationDescription ste = new OperationDescription();
            str.deleteOperationDescription(str.OPERASYON_KODU);

            return Redirect("/Production/OperationDescription");
        }

        public IActionResult OperationDescriptionEdit(int Id)
        {

            OperationDescription str = new OperationDescription();
            str.operasyonBilgisiGetir();
            str.getOperationDescription(Id);

            str.dt.Tables[0].TableName = "operasyon";



            return View("~/Views/Production/OperationDescription/OperationDescription1.cshtml", str);

        }


    }
}
