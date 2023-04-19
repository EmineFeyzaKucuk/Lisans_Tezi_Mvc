using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;

namespace Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo
{
    public class CurrentCardIdentificationRepository : GenericRepository<ACCOUNTING_CURRENT_CARD_DEFINITION>, ICurrentCardIdentificationRepository
    {
        public CurrentCardIdentificationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public ACCOUNTING_CURRENT_CARD_DEFINITION GetByName(string name)
        {
            var data = _appDbContext.Muhasebe_CariKartTanimlama.ToList();
            var currentCardDefinition = data.First(x => x.CARI_KODU == name);
            return currentCardDefinition;
        }
    }
}
