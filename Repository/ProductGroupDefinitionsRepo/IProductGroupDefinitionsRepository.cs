using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.ProductGroupDefinitionsRepo
{
    public interface IProductGroupDefinitionsRepository : IRepository<PRODUCT_GROUP_DEFINITIONS>
    {

        PRODUCT_GROUP_DEFINITIONS GetByName(string name);

        PRODUCT_GROUP_DEFINITIONS GetById(int id);


    }
}
