using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.WaterFootPrintRepo
{
    public interface IWaterFootPrintRepository : IRepository<WATER_FOOTPRINT>
    {


        WATER_FOOTPRINT GetByName(string name);

        WATER_FOOTPRINT GetById(int id);
    }
}
