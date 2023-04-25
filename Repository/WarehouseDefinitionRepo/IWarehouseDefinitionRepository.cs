using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo
{
    public interface IWarehouseDefinitionRepository : IRepository<WAREHOUSE_DEFINITION>
    {


        WAREHOUSE_DEFINITION GetByName(string name);
        WAREHOUSE_DEFINITION GetById(int id);


    }
}
