using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.OperatorTypesDescriptionRepo;
using Lisans_Tezi_Mvc.Repository.ProductGroupDefinitionsRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductGroupDefinitionsController :Controller
    {
        private readonly IProductGroupDefinitionsRepository _productGroupDefinitionsRepository;

        public ProductGroupDefinitionsController(IProductGroupDefinitionsRepository productGroupDefinitionsRepository)
        {
            _productGroupDefinitionsRepository = productGroupDefinitionsRepository;
        }
        public IActionResult CreateProductGroupDefinitions(PRODUCT_GROUP_DEFINITIONS productGroupDefinitions)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _productGroupDefinitionsRepository.Add(productGroupDefinitions);
                return RedirectToAction("ProductGroupDefinitions", "Production");
            }
            catch (Exception)
            {
                return BadRequest("Eklenemedi");
            }
        }
    }
}
