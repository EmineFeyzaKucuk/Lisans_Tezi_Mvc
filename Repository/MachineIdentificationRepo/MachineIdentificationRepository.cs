using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo
{
    public class MachineIdentificationRepository : GenericRepository<MACHINE_IDENTIFICATION>, IMachineIdentificationRepository
    {
        public MachineIdentificationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public MACHINE_IDENTIFICATION GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
