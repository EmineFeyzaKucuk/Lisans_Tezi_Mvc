namespace Lisans_Tezi_Mvc.Models
{
    public class CARBON_FOOTPRINT :BaseEntity
    {
        public string TUKETIM_SEKLI { get; set; }

        public double YILLIK_TOPLAM_TUKETIM { get; set; }

        public double KARBON_AYAK_IZI_HESAPLAMA { get; set; }
    }
}
