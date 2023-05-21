using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.StockEntryExitMovementsRepo
{
    public interface IStockEntryExitMovementsRepository : IRepository<STOCK_IN_AND_OUT>
    {



        STOCK_IN_AND_OUT GetByName(string name);

        STOCK_IN_AND_OUT GetById(int id);
    }
}
