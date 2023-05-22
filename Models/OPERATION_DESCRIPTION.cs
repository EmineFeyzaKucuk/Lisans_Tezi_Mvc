namespace Lisans_Tezi_Mvc.Models
{
    public class OPERATION_DESCRIPTION :BaseEntity
    {
        public string OPERASYON_KODU { get; set; }
        public string OPERASYON_ADI { get; set; }
        public bool A_P { get; set; }
        public string NORMAL_IS_GUNLERI { get; set; }
        public string CUMARTESI { get; set; }
        public string PAZAR { get; set; }
        public string HAFTALIK_KAPASITE { get; set; }
        public int KAPASITE { get; set; }
        public string OPERASYON_ACIKLAMA { get; set; }

    }
}
