namespace Lisans_Tezi_Mvc.Models
{
    public class BARCODE_RECORDS : BaseEntity
    {
        public int BARKOD_KAYITLARI_ID { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public char A_D { get; set; }
        public char A_P { get; set; }
        public int BARKOD { get; set; }
        public string ACIKLAMA { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public char BARKOD_TIPI { get; set; }
        public char OLCU_BIRIMI { get; set; }
        public char KILIT { get; set; }
    }
}
