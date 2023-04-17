using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;


namespace Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo
{
    public class AccountingCodeDefinitionRepository : GenericRepository<ACCOUNTING_CODE_DEFINITION>, IAccountingCodeDefinitionRepository
    {
        public AccountingCodeDefinitionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }



        public ACCOUNTING_CODE_DEFINITION GetByName(string name)
        {
            var data = _appDbContext.MuhasebeKodTanimlama_TBL.ToList();
            var accountingCodeDefinition = data.First(x => x.MUHASEBE_ADI == name);
            return accountingCodeDefinition;
        }


    }


}




