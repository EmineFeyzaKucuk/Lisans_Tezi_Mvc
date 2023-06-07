namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_CARD_PROCESS_Framework : BaseEntity
    {
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public int RISK_SURESI { get; set; }
        public int ZAMAN_BIRIMI { get; set; }
        public int MUHASEBE_ID { get; set; }
        public int DEPO_ID { get; set; }
        public int CARI_ID { get; set; }
        public int MIKTAR_BIRIM_ID { get; set; }
        public float MIKTAR { get; set; }
        public float BOY { get; set; }
        public float EN { get; set; }
        public float YUKSEKLIK { get; set; }
        public float SATIS_FIYAT { get; set; }
        public float SATIS_FIYAT_KDY { get; set; }
        public float ALIS_FIYAT { get; set; }
        public float ALIS_FIYAT_KDY { get; set; }


    }
}
