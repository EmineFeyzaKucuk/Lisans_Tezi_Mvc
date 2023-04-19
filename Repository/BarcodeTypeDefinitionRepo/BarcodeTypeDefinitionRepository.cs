using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Models;


namespace Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo
{
    public class BarcodeTypeDefinitionRepository : GenericRepository<GENERAL_BARCODE_TYPE_DEFINITION>, IBarcodeTypeDefinitionRepository
    {
        public BarcodeTypeDefinitionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public GENERAL_BARCODE_TYPE_DEFINITION GetByName(string name)
        {
            var data = _appDbContext.Genel_BarkodTipiTanimlama_TBL.ToList();
            var generalBarcodeDefinition = data.First(x => x.BARKOD_TIPI == name);
            return generalBarcodeDefinition;
        }
    }



}
