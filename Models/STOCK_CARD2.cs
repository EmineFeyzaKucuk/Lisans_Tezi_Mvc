namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_CARD2 : BaseEntity
    {

       
        public string STOK_KODU{ get; set; }
        public int CARI_KODU { get; set; }
        public int URETICI_KOD { get; set; }
        public char OLC_BR{ get; set; }
        public decimal EN { get; set; }
        public decimal BOY { get; set; }
        public decimal YUKSEKLIK{ get; set; }
     
      
    }
}
