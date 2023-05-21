namespace Lisans_Tezi_Mvc.Models
{
    public class PRODUCTION_ORDER_ENTRY :BaseEntity
    {
        public string URETIM_EMRI_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string URETIM_EMRI_VEREN { get; set; }
        public string ACIKLAMA { get; set; }
        public string SIPARIS_NO { get; set; }
        public string CARI_HESAP_KODU { get; set; }
        public string CARI_HESAP_ADI { get; set; }
        public string STOK_KODU { get; set; }
        public int ISLEM_MIKTARI { get; set; }
        public string ISLEM_BIRIMI { get; set; }
        public DateTime IMALAT_TESLIM_TARIHI { get; set; }
        public DateTime MUSTERIYE_TESLIM_TARIHI { get; set; }
        public int URETILEN_TOPLAM_MIKTAR { get; set; }
        public int KALAN { get; set; }

    }
}
