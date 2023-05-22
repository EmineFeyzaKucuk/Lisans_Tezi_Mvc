using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;

namespace Lisans_Tezi_Mvc.Repository.OperationDescriptionRepo
{
    public class OperationDescriptionRepository : GenericRepository<OPERATION_DESCRIPTION>, IOperationDescriptionRepository
    {
        public OperationDescriptionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public OPERATION_DESCRIPTION GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
