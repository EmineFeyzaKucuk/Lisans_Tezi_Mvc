using Lisans_Tezi_Mvc.Controllers;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class BarcodeTypeDefinitionController :Controller
    {

        private readonly IBarcodeTypeDefinitionRepository _barcodeTypeDefinitionRepository;

        public BarcodeTypeDefinitionController(IBarcodeTypeDefinitionRepository barcodeTypeDefinitionRepository)
        {
            _barcodeTypeDefinitionRepository = barcodeTypeDefinitionRepository;
        }

        public IActionResult BarcodeTypeDefinition()
        {
            var data = _barcodeTypeDefinitionRepository.GetAll();

            if (data.Count > 0)
            {
                return View("~/Views/GeneralOperations/Definitions/BarcodeTypeDefinition.cshtml", data);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(GENERAL_BARCODE_TYPE_DEFINITION barcodeTypeDefinition)
        {
            try
            {
                _barcodeTypeDefinitionRepository.Add(barcodeTypeDefinition);
                return RedirectToAction("BarcodeTypeDefinition");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

    }
}





