namespace Lisans_Tezi_Mvc.Models
{
    public class WAREHOUSE_DEFINITION : BaseEntity
    {
      
        public int DEPO_KODU { get; set; }
        public string DEPO_ADI { get; set; }
     
        public bool E_TICARET { get; set; }
        public string TESIS_KODU { get; set; }
        public string LOKASYON_KODU{ get; set; }
     
        public int PERSONEL_ID { get; set; }
        public string PERSONEL_IS { get; set; }
    
    }
}
