using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo
{ 
    public interface IGroupCodeRecordsRepository : IRepository<GROUP_CODE_DEFINITIONS>
    {
        GROUP_CODE_DEFINITIONS GetByName(string name);
    }
}
