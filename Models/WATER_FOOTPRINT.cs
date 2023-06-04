namespace Lisans_Tezi_Mvc.Models
{
    public class WATER_FOOTPRINT :BaseEntity
    {
        public float PAMUK_URETIMI { get; set; }
        public float KUMAS_URETIMI { get; set; }
        public float BOYAMA_URETIMI { get; set; }
        public float URUN_URETIMI { get; set; }
        public float SU_AYAK_IZI_TOPLAM { get; set; }
        public DateTime TARIH { get; set; }


    }
}
