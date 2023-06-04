using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;
using Lisans_Tezi_Mvc.Repository.DebitMemoRepo;

namespace Lisans_Tezi_Mvc.Repository.CreditNoteRepo
{
    public class CreditNoteRepository : GenericRepository<CREDIT_NOTE>, ICreditNoteRepository
    {
        public CreditNoteRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public CREDIT_NOTE GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
