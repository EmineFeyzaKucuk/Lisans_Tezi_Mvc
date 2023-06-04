namespace Lisans_Tezi_Mvc.Models
{
    public class BARCODE_RECORDS : BaseEntity
    {

        public string STOK_KODU { get; set; }
    
        public int BARKOD { get; set; }
        public string ACIKLAMA { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public string BARKOD_TIPI { get; set; }
        public string OLCU_BIRIMI_KODU { get; set; }
    
    }

    
}
