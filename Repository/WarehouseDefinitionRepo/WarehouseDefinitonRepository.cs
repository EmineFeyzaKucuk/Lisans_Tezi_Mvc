using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

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
    }
}











