using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.OperatorDescriptionRepo
{
    public interface IOperatorDescriptionRepository : IRepository<OPERATOR_DESCRIPTION>
    {

        OPERATOR_DESCRIPTION GetByName(string name);

        OPERATOR_DESCRIPTION GetById(int id);
    }
}
