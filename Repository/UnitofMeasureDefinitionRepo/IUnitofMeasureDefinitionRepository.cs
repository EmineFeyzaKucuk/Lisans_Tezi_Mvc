using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo
{
    public interface IUnitofMeasureDefinitionRepository : IRepository<GENERAL_MEASUREMENT_UNIT>
    {

        GENERAL_MEASUREMENT_UNIT GetByName(string name);
    }
}
