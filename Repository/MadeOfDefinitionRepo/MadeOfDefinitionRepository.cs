using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.MadeOfDefinitionRepo
{
    public class MadeOfDefinitionRepository : GenericRepository<GENERAL_MADE_OF_DEFINITION>, IMadeOfDefinitionRepository
    {
        public MadeOfDefinitionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public GENERAL_MADE_OF_DEFINITION GetByName(string name)
        {
            var data = _appDbContext.Genel_MamulKoduTanimlama_TBL.ToList();
            var madeofDefinition = data.First(x => x.MAMUL_KODU == name);
            return madeofDefinition;
        }
    }
}
