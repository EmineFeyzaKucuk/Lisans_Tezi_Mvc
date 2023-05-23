using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.MachineIdentificationRepo;

namespace Lisans_Tezi_Mvc.Repository.ProductGroupDefinitionsRepo
{
    public class ProductGroupDefinitionsRepository : GenericRepository<PRODUCT_GROUP_DEFINITIONS>, IProductGroupDefinitionsRepository
    {
        public ProductGroupDefinitionsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public PRODUCT_GROUP_DEFINITIONS GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
