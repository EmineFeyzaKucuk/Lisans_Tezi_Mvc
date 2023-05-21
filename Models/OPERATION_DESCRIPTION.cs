namespace Lisans_Tezi_Mvc.Models
{
    public class OPERATION_DESCRIPTION :BaseEntity
    {
        public string OPERASYON_KODU { get; set; }
        public string OPERASYON_ADI { get; set; }
        public int KAPASITE { get; set; }
        public string OPERASYON_ACIKLAMA { get; set; }

    }
}
