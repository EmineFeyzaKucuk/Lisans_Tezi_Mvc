using Lisans_Tezi_Mvc.Models;

namespace Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo
{
    public interface IAccountingCodeDefinitionRepository : IRepository<ACCOUNTING_CODE_DEFINITION>
    {

        ACCOUNTING_CODE_DEFINITION GetByName(string name);


    }
}







