using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo
{
    public interface ICurrentCardIdentificationRepository : IRepository<ACCOUNTING_CURRENT_CARD_DEFINITION>
    {

        ACCOUNTING_CURRENT_CARD_DEFINITION GetByName(string name);

    }
}
