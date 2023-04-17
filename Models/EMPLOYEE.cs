namespace Lisans_Tezi_Mvc.Models
{
    public class EMPLOYEE : BaseEntity
    {
        public int Id { get; set; }
        public int PERSONEL_KODU { get; set; }
        public string PERSONEL_ISIM { get; set; }
        public string ADRES { get; set; }
        public string POSTA_KODU { get; set; }
        public string GSM { get; set; }
        public string E_POSTA { get; set; }


    }
}