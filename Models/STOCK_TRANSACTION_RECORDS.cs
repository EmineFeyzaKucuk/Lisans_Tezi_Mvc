namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_TRANSACTION_RECORDS : BaseEntity
    {
        public string STOK_KODU { get; set; }
        public int GRUP_KODU{ get; set; }
        public string TARIH{ get; set; }
        public int CARI_KOD { get; set; }
      
    }
}
