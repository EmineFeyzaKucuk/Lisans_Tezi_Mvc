using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.OperatorTypesDescriptionRepo
{
    public interface IOperatorTypesDescriptionRepository : IRepository<OPERATOR_TYPES_DESCRIPTION>
    {

        OPERATOR_TYPES_DESCRIPTION GetByName(string name);

        OPERATOR_TYPES_DESCRIPTION GetById(int id);
    }
}
