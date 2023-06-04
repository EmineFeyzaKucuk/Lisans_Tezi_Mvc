using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using System.Security.Policy;

namespace Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo
{
    public class CurrentCardIdentificationRepository : GenericRepository<ACCOUNTING_CURRENT_CARD_DEFINITION>, ICurrentCardIdentificationRepository
    {
        public CurrentCardIdentificationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public ACCOUNTING_CURRENT_CARD_DEFINITION GetByName2(string name)
        {
            var data7 = _appDbContext.Muhasebe_CariKartTanimlama_TBL.ToList();
            var currentCardDefinition = data7.First(x => x.CARI_KODU == name);
            return currentCardDefinition;
        }
        public GENERAL_CURRENCY_DEFINITION GetByName(string name)
        {
            var data8 = _appDbContext.Genel_ParaBirimiTanimlama_TBL.ToList();
            var generalCurrencyDefinition = data8.First(x => x.PARA_BIRIMI_KODU == name);
            return generalCurrencyDefinition;


        }
       
    }
}
