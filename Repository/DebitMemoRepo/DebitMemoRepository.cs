using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;

namespace Lisans_Tezi_Mvc.Repository.DebitMemoRepo
{
    public class DebitMemoRepository : GenericRepository<DEBIT_MEMO>, IDebitMemoRepository
    {
        public DebitMemoRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public DEBIT_MEMO GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
