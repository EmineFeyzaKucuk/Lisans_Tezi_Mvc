using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo;

namespace Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo
{
    public class GroupCodeRecordsRepository : GenericRepository<GROUP_CODE_DEFINITIONS>, IGroupCodeRecordsRepository
    {
        public GroupCodeRecordsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public GROUP_CODE_DEFINITIONS GetByName(string name)
        {
            var data = _appDbContext.Stok_GrupKodTanimlama_TBL.ToList();
            var grupkod = data.First(x => x.GRUP_ADI == name);
            return grupkod;
        }
    }
    }

