namespace Lisans_Tezi_Mvc.Models
{
    public class SAFETY_STOCK : BaseEntity
    {
        public double gunlukTalep { get; set; }
        public double gdkatsayi { get; set; }
        public  double standartSapma { get; set; }
        public int teslimSuresi { get; set; }
        public double result { get; set; }
        


    }
}
