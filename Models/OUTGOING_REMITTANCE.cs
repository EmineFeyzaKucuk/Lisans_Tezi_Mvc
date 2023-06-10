namespace Lisans_Tezi_Mvc.Models
{
    public class OUTGOING_REMITTANCE: BaseEntity
    {
        public string FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string ALACAKLI_BANKA_HESAP_KODU { get; set; }
        public string NITELIK { get; set; }
        public string TUTAR { get; set; }

    }
}
