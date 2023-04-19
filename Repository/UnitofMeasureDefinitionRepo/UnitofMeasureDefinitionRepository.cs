using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo
{
    public class UnitofMeasureDefinitionRepository : GenericRepository<GENERAL_MEASUREMENT_UNIT>, IUnitofMeasureDefinitionRepository
    {
        public UnitofMeasureDefinitionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public GENERAL_MEASUREMENT_UNIT GetByName(string name)
        {
            var data = _appDbContext.Genel_OlcuBirimiTanimlama_TBL.ToList();
            var generalMeasurementDefinition = data.First(x => x.OLCU_BIRIMI_KODU == name);
            return generalMeasurementDefinition;
        }
    }
}
