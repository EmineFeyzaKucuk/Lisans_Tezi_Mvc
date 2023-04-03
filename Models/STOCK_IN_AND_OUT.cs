namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_IN_AND_OUT
    {
        public int FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public char DEPO { get; set; }
        public string NOT { get; set; }
        public string STOK_KODU{ get; set; }
        public string STOK_ADI{ get; set; }
        public int PARTI_NO { get; set; }
        public int GELEN_MIKTAR { get; set; }
        public int CIKAN_MIKTAR { get; set; }
        public char ISLEM_BIRIMI { get; set; }
       
    }
}
