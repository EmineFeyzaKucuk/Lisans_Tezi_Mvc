using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.BarcodeRecordsRepo
{
    public interface IBarcodeRecordsRepository : IRepository<BARCODE_RECORDS>
    {


        BARCODE_RECORDS GetById(int id);

    }
}
