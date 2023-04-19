using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo
{
    public class CurrencyDefinitionRepository : GenericRepository<GENERAL_CURRENCY_DEFINITION>, ICurrencyDefinitionRepository
    {
        public CurrencyDefinitionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public GENERAL_CURRENCY_DEFINITION GetByName(string name)
        {

            var data = _appDbContext.Genel_ParaBirimiTanimlama_TBL.ToList();
            var generalCurrencyDefinition = data.First(x => x.PARA_BIRIMI_KODU == name);
            return generalCurrencyDefinition;
        }



    }
}
