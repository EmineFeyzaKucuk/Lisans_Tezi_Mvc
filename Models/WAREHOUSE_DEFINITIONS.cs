namespace Lisans_Tezi_Mvc.Models
{
    public class WAREHOUSE_DEFINITIONS : BaseEntity
    {
        public int ID { get; set; }
        public int DEPO_KODU { get; set; }
        public string DEPO_ADI { get; set; }
     
        public char E_TICARET { get; set; }
        public string TESIS_KODU { get; set; }
        public char LOKASYON_KODU{ get; set; }
     
        public int PERSONEL_ID { get; set; }
        public char PERSONEL_IS { get; set; }
    
    }
}
