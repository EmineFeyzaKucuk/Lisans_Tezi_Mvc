namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_TRANSACTION_RECORDS_ENTRY : BaseEntity
    {
    
        public string STOK_KODU { get; set; }
        public DateTime TARIH { get; set; }
        public string FIS_NO { get; set; }
        public decimal FIYAT { get; set; }
        public string STOK_HAREKET_DURUMU{ get; set; }
        public string DEPO_KODU{ get; set; }
        public string MALIYET { get; set; }
        public string ACIKLAMA { get; set; }
        public decimal MALIYET_FIYATI { get; set; }
        public int GIRIS_MIKTARI { get; set; }
        public int CIKIS_MIKTARI { get; set; }
        public decimal GIRIS_TUTARI{ get; set; }
        public decimal CIKIS_TUTARI { get; set; }
        public int BAKIYE_MIKTARI { get; set; }
    }
}
