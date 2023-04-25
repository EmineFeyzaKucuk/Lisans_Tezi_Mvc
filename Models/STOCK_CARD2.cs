namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_CARD2 : BaseEntity
    {

       
        public string STOK_KODU{ get; set; }
        public string CARI_KODU { get; set; }
        public string OLCU_BIRIMI_KODU{ get; set; }
        public int OLC_BR_DEGER { get; set; }
        public decimal EN { get; set; }
        public decimal BOY { get; set; }
        public decimal YUKSEKLIK{ get; set; }
     
      
    }
}
