namespace Lisans_Tezi_Mvc.Models
{
    public class WAREHOUSE_TRANSFER_RECEIPT : BaseEntity
    {
       
        public int FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string GONDEREN_DEPO { get; set; }
        public string ALAN_DEPO { get; set; }
        public string STOK_KODU { get; set; }
        public int PARTI_NO{ get; set; }
        public int ISLEM_MIKTARI{ get; set; }
        public string ISLEM_BIRIMI { get; set; }
        public string ACIKLAMA{ get; set; }
 
    }
}
