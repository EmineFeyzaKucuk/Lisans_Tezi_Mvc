using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.StockInformationRepo
{
    public interface IStockInformationRepository : IRepository<STOCK_INFORMATION>
    {
        //stock_information a özel bir method burada tanımlanabilir.
       // void GetByStockInfoName(string name);


        STOCK_INFORMATION  GetByName(string name);
    }


}
