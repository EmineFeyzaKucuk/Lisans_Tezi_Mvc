namespace Lisans_Tezi_Mvc.Models
{
    public class RISKY_PRODUCT_GROUPS : BaseEntity
    {

        public int Id { get; set; }
        public int GRUP_KODU{ get; set; }
        public string GRUP_ADI { get; set; }
        public string MESAJ { get; set; }
        public string UYARI_EKRAN { get; set; }

    }
}
