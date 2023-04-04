namespace Lisans_Tezi_Mvc.Models
{
    public class PRICE_LIST : BaseEntity
    {
        public int KOD{ get; set; }
        public char TIP{ get; set; }
        public DateTime BASLANGIC_TARIHI { get; set; }
        public DateTime BITIS_TARIHI { get; set; }
        public string ACIKLAMA { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public decimal FIYAT { get; set; }
        public char PARA_BIRIMI { get; set; }
        public char STOK_ISLEM_BIRIMI{ get; set; }
        public char KULLANIM_YERI { get; set; }
      
    }
}
