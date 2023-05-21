using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo
{
    public interface IMachineIdentificationRepository : IRepository<MACHINE_IDENTIFICATION>
    {


        MACHINE_IDENTIFICATION GetByName(string name);

        MACHINE_IDENTIFICATION GetById(int id);

    }
}
