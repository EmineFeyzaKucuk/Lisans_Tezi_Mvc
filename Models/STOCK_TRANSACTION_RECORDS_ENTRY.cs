namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_TRANSACTION_RECORDS_ENTRY
    {
        public int STOK_HAREKET_KAYITLARI_ID { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public datetime TARIH { get; set; }
        public char FIS_NO { get; set; }
        public char TIP { get; set; }
        public decimal FIYAT { get; set; }
        public char STOK_HAREKET_DURUMU{ get; set; }
        public string MALIYET { get; set; }
        public string ACIKLAMA { get; set; }
        public string MALIYET_FIYATI { get; set; }
        public int GIRIS_MIKTARI { get; set; }
        public int CIKIS_MIKTARI { get; set; }
        public decimal GIRIS_TUTARI{ get; set; }
        public decimal CIKIS_TUTARI { get; set; }
        public int BAKIYE_MIKTARI { get; set; }
    }
}
