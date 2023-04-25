using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using System.Xml.Linq;

namespace Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo
{
    public class WarehouseDefinitonRepository : GenericRepository<WAREHOUSE_DEFINITION>, IWarehouseDefinitionRepository
    {
        public WarehouseDefinitonRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }



        public WAREHOUSE_DEFINITION GetByName(string name)
        {
            var data = _appDbContext.DepoTanimlama_TBL.ToList();
            var warehouseefinition = data.First(x => x.DEPO_ADI == name);
            return warehouseefinition;
        }


       public  WAREHOUSE_DEFINITION GetById(int id)
        {
            var data2 = _appDbContext.DepoTanimlama_TBL.ToList();
            var warehouseefinition2 = data2.First(x => x.DEPO_KODU == id);
            return warehouseefinition2;

           
        }
    }
}











