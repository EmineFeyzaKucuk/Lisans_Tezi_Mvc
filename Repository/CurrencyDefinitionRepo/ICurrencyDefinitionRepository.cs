using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo
{
    public interface ICurrencyDefinitionRepository : IRepository<GENERAL_CURRENCY_DEFINITION>
    {
        GENERAL_CURRENCY_DEFINITION GetByName(string name);

    }
}
