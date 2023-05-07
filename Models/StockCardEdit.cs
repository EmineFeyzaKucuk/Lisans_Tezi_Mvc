namespace Lisans_Tezi_Mvc.Models
{
    public class StockCardEdit:BaseEntity
    {
        public int Id { get; set; }
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
    }
}







