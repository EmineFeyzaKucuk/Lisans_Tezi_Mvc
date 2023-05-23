namespace Lisans_Tezi_Mvc.Models
{
    public class WORKSTATION_IDENTIFICATION :BaseEntity
    {
        public string ISTASYON_KODU { get; set; }
        public string ISTASYON_ADI { get; set; }
        public bool A_P { get; set; }
        public string OPERATOR_KODU { get; set; }
        public string MAKINE_KODU { get; set; }
        public int URETIM_SURESI { get; set; }
        public int HAZIRLIK_SURESI { get; set; }

    }
}
