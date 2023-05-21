namespace Lisans_Tezi_Mvc.Models
{
    public class MACHINE_IDENTIFICATION :BaseEntity
    {
        public string MAKINE_KODU { get; set; }
        public string MAKINE_ADI { get; set; }
        public string A_P { get; set; }
        public int MAKINE_SAYISI { get; set; }
        public string ACIKLAMA { get; set; }
        public int URETIM_SURESI { get; set; }
        public int HAZIRLIK_SURESI { get; set; }

    }
}
