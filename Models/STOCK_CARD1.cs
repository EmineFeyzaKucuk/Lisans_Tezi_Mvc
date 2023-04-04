namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_CARD1 : BaseEntity
    {
        public int STOCK_CARD1_ID { get; set; }
        public string STOK_KODU{ get; set; }
        public string STOK_ADI{ get; set; }
        public char A_D{ get; set; }
        public char A_P { get; set; }
        public int SATIS_KDV_ORANI { get; set; }
        public int ALIS_KDV_ORANI { get; set; }
        public string RISK_SURESI { get; set; }
        public DateTime ZAMAN_BIRIMI { get; set; }
        public int MUH_DETAY { get; set; }
        public int DEPO_KODU { get; set; }
      
    }
}
