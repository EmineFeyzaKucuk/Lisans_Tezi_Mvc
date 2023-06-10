using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class ACCOUNTING_CURRENT_CARD_DEFINITION: BaseEntity
    {

      
        public string CARI_KODU { get; set; }
        public string UNVAN { get; set; }
        public string ADRES { get; set; }
        public string POSTA_KODU { get; set; }
        public string VERGI_ADRESI { get; set; }
        public int VERGI_NO{ get; set; }
        public string TELEFON { get; set; }
        public int FAX { get; set; }
        public int MUH_DETAY { get; set; }
        public string PARA_BIRIMI { get; set; }

       

       



    }
}
