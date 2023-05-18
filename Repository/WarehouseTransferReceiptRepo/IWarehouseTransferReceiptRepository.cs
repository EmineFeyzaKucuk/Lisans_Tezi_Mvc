using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository;

namespace Lisans_Tezi_Mvc.Repository.WarehouseTransferReceiptRepo
{
    public interface IWarehouseTransferReceiptRepository : IRepository<WAREHOUSE_TRANSFER_RECEIPT>
    {
        WAREHOUSE_TRANSFER_RECEIPT GetByName(string name);

        WAREHOUSE_TRANSFER_RECEIPT GetById(int id);
    }
}
