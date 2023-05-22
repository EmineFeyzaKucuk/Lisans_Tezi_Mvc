using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;

namespace Lisans_Tezi_Mvc.Repository.OperatorDescriptionRepo
{
    public class OperatorDescriptionRepository : GenericRepository<OPERATOR_DESCRIPTION>, IOperatorDescriptionRepository
    {
        public OperatorDescriptionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public OPERATOR_DESCRIPTION GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
