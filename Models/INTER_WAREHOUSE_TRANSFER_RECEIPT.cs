namespace Lisans_Tezi_Mvc.Models
{
    public class INTER_WAREHOUSE_TRANSFER_RECEIPT : BaseEntity
    {
        public char FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public char GONDEREN_DEPO { get; set; }
        public char ALAN_DEPO { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public int PARTI_NO{ get; set; }
        public int ISLEM_MIKTARI{ get; set; }
        public string ISLEM_BIRIMI { get; set; }
        public int STOK_MIKTARI{ get; set; }
        public string STOK_BIRIMI{ get; set; }
        public string ACIKLAMA{ get; set; }
 
    }
}
