using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.OperatorTypesDescriptionRepo;

namespace Lisans_Tezi_Mvc.Repository.WorkstationIdentificationRepo
{
    public class WorkstationIdentificationRepository : GenericRepository<WORKSTATION_IDENTIFICATION>, IWorkstationIdentificationRepository
    {
        public WorkstationIdentificationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
