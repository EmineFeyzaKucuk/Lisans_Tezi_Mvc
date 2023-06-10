using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.ProductionOrderEntryRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class ProductionOrderEntryController: Controller
    {

        private readonly IProductionOrderEntryRepository _productionOrderEntryRepository;

        public ProductionOrderEntryController(IProductionOrderEntryRepository productionOrderEntryRepository)
        {
            _productionOrderEntryRepository = productionOrderEntryRepository;
        }

        public IActionResult CreateProductionOrderEntry(PRODUCTION_ORDER_ENTRY productionOrderEntry)
        {
            try
            {
                //  return Ok(stock_in_and_out);
                _productionOrderEntryRepository.Add(productionOrderEntry);
                return RedirectToAction("ProductionOrderEntry", "Production");
            }
            catch (Exception)
            {

                return BadRequest("Eklenemedi");
            }

        }

        public IActionResult ProductionOrderEntryEdit(int Id)
        {

            ProductionOrderEntry str = new ProductionOrderEntry();
            str.uretimEmriBilgisiGetir();
            str.getProductionOrderEntry(Id);

            str.dt.Tables[0].TableName = "personel";
            str.dt.Tables[1].TableName = "cari";
            str.dt.Tables[2].TableName = "Stokkodları";
            str.dt.Tables[3].TableName = "olcu";



            return View("~/Views/Production/ProductionOrderEntry/ProductionOrderEntry1.cshtml", str);

        }

        public IActionResult ProductionOrderEntrynew()
        {

            ProductionOrderEntry str = new ProductionOrderEntry();
            str.uretimEmriBilgisiGetir();
           
            str.dt.Tables[0].TableName = "personel";
            str.dt.Tables[1].TableName = "cari";
            str.dt.Tables[2].TableName = "Stokkodları";
            str.dt.Tables[3].TableName = "olcu";

            return View("~/Views/Production/ProductionOrderEntry/ProductionOrderEntry1.cshtml", str);
          

        }
        public IActionResult ProductionOrderEntrySave(ProductionOrderEntry str)
        {
            ProductionOrderEntry ste = new ProductionOrderEntry();
            str.saveProductionOrderEntry(str);


            return Redirect("/Production/ProductionOrderEntry");
        }

        public IActionResult ProductionOrderEntryDelete(ProductionOrderEntry str)
        {
            ProductionOrderEntry ste = new ProductionOrderEntry();
            str.deleteProductionOrderEntry(str.URETIM_EMRI_NO);

            return Redirect("/Production/ProductionOrderEntry");
        }

    }
}
