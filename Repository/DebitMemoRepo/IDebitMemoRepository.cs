using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.DebitMemoRepo
{
    public interface IDebitMemoRepository : IRepository<DEBIT_MEMO>
    {

        DEBIT_MEMO GetByName(string name);
    }
}
