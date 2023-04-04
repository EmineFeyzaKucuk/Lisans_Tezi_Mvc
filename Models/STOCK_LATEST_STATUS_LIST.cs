namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_LATEST_STATUS_LIST : BaseEntity
    {
        public string STOK_KODU { get; set; }
        public int GRUP_KODU { get; set; }
        public char BAKIYE_FILTRE { get; set; }
        public char RAPOR_BIRIMI { get; set; }
      
    }
}
