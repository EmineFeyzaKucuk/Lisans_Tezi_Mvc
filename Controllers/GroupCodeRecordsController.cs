using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository;
using Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo;
using Microsoft.AspNetCore.Mvc;

namespace Lisans_Tezi_Mvc.Controllers
{
    public class GroupCodeRecordsController : Controller
    {
        private readonly IGroupCodeRecordsRepository _groupCodeRecordsRepository;

        public GroupCodeRecordsController(IGroupCodeRecordsRepository groupCodeRecordsRepository)
        {
            _groupCodeRecordsRepository = groupCodeRecordsRepository;
        }
        public IActionResult GroupCodeRecords()
        {
            ViewBag.data1 = _groupCodeRecordsRepository.GetAll();

            if (ViewBag.data1.Count > 0)
            {
                return View(ViewBag.data1);
            }
            return Ok("Liste Boş");

        }
        public IActionResult Add(GROUP_CODE_DEFINITIONS groupCodeDefinition)
        {
            try
            {
                _groupCodeRecordsRepository.Add(groupCodeDefinition);
                return RedirectToAction("GroupCodeRecords", "Stock");
            }
            catch (Exception)
            {
                
                return BadRequest("Eklenemedi");
            }

        }

        public IActionResult GroupCodeDelete(GROUP_CODE_RECORDS gcr)
        {
            GROUP_CODE_RECORDS ste = new GROUP_CODE_RECORDS();
            gcr.deleteGroupCodeRecords(gcr.GRUP_KODU);

            return Redirect("/Stock/GroupCodeRecords");
        }


        //public IActionResult GrupCodeDelete(GROUP_CODE_DEFINITIONS groupCodeDefinition)
        //{
        //    int grupKodu = Convert.ToInt32(Request.Form["GRUP_KODU"].ToString());


        //    _groupCodeRecordsRepository.Delete(grupKodu);

        //    return RedirectToAction("GroupCodeRecords", "Stock");
        //}

        public IActionResult deleteGroupCodeRecords(GROUP_CODE_RECORDS groupCodeRecordsRepository)
        {
            GROUP_CODE_RECORDS gc = new GROUP_CODE_RECORDS();

            gc.deleteGroupCodeRecords(groupCodeRecordsRepository.GRUP_KODU);
            

            return RedirectToAction("GroupCodeRecords", " /Stock/GroupCodeRecords");
        }


       
    }
}

