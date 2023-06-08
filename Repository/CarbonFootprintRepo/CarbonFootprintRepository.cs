using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.CarbonFootprintRepo
{
    public class CarbonFootprintRepository : GenericRepository<CARBON_FOOTPRINT>, ICarbonFootprintRepository
    {
        public CarbonFootprintRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }


}

