namespace Lisans_Tezi_Mvc.Models
{
    public class WATER_FOOTPRINT :BaseEntity
    {
        public double PAMUK_URETIMI { get; set; }
        public double KUMAS_URETIMI { get; set; }
        public double BOYAMA_URETIMI { get; set; }
        public double URUN_URETIMI { get; set; }
        public double SU_AYAK_IZI_TOPLAM { get; set; }
        public DateTime TARIH { get; set; } = DateTime.Now; 


    }
}
