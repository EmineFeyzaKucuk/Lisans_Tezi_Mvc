using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository;

namespace Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo
{
    public interface IBarcodeTypeDefinitionRepository : IRepository<GENERAL_BARCODE_TYPE_DEFINITION>

    {
        GENERAL_BARCODE_TYPE_DEFINITION GetByName(string name);

    }
}
