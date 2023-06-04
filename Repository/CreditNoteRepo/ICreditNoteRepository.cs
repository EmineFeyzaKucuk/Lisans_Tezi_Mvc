using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.CreditNoteRepo
{
    public interface ICreditNoteRepository : IRepository<CREDIT_NOTE>
    {
        CREDIT_NOTE GetByName(string name);

    }
}
