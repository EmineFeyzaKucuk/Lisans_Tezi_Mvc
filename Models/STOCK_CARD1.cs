namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_CARD1 : BaseEntity
    {
      
        public string STOK_KODU{ get; set; }
        public string STOK_ADI { get; set; }
        public int SATIS_KDV_ORANI { get; set; }
        public int ALIS_KDV_ORANI { get; set; }
        public string RISK_SURESI { get; set; }
        public DateTime ZAMAN_BIRIMI { get; set; }
        public int MUH_DETAY_KODU { get; set; }
        public int DEPO_KODU { get; set; }
      
    }
}
