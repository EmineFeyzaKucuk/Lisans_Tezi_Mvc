namespace Lisans_Tezi_Mvc.Models
{
    public class NOTIFICATION : BaseEntity
    {
        public int ID { get; set; }
        public int UYGULAMA_ID { get; set; }
        public string MESAJ{ get; set; }
        public DateTime TARIH { get; set; }
     
    }
}
