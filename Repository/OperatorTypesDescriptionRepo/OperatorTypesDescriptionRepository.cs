using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.OperationDescriptionRepo;

namespace Lisans_Tezi_Mvc.Repository.OperatorTypesDescriptionRepo
{
    public class OperatorTypesDescriptionRepository : GenericRepository<OPERATOR_TYPES_DESCRIPTION>, IOperatorTypesDescriptionRepository
    {
        public OperatorTypesDescriptionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public OPERATOR_TYPES_DESCRIPTION GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }

}