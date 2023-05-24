using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.MadeOfDefinitionRepo
{
    public interface IMadeOfDefinitionRepository : IRepository<GENERAL_MADE_OF_DEFINITION>
    {

        GENERAL_MADE_OF_DEFINITION GetByName(string name);

    }
}
