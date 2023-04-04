namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_GROUP_CODE : BaseEntity
    {
        public int STOCK_GROUP_KODU_ID { get; set; }
        public string STOK_KODU{ get; set; }
        public string STOK_ADI { get; set; }
        public string GRUP_KODU{ get; set; }
        public string GRUP_ADI { get; set; }
    }
}
