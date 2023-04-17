namespace Lisans_Tezi_Mvc.Models
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string AD_SOYAD { get; set; }
        public string GSM { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE{ get; set; }
        public int ROL_ID { get; set; }
        public Boolean AKTIF{ get; set; }
    }


}
