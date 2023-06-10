namespace Lisans_Tezi_Mvc.Models
{
    public class PRODUCTION_RECORD : BaseEntity
    {
               
        public string BELGE_NO { get; set; }
        public string TARIH { get; set; }
        public string URETIM_EMRI_NO { get; set; }
        public int DEPO { get; set; }
        public string MAMUL_KODU { get; set; }
        public string MIKTAR { get; set; }
        public string STOK_KODU { get; set; }
        public string OLCU_BIRIMI { get; set; }
        public string ACIKLAMA { get; set; }

    }
}
