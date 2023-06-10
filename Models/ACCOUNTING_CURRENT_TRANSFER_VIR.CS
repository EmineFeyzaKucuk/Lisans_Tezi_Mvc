using System.ComponentModel;

namespace Lisans_Tezi_Mvc.Models
{
    public class ACCOUNTING_CURRENT_TRANSFER_VIR :BaseEntity
    {
        public string BELGE_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string ALACAKLI_HESAP_KODU { get; set; }
        public string BORCLU_HESAP_KODU { get; set; }

        public string BORC_TUTARI { get; set; }
        public string PARA_BIRIMI { get; set; }
        public string ACIKLAMA { get; set; }
     
    }
}
