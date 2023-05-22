using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.OperationDescriptionRepo
{
    public interface IOperationDescriptionRepository : IRepository<OPERATION_DESCRIPTION>
    {
        OPERATION_DESCRIPTION GetByName(string name);

        OPERATION_DESCRIPTION GetById(int id);

    }
}
