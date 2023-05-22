namespace Lisans_Tezi_Mvc.Models
{
    public class OPERATOR_DESCRIPTION :BaseEntity
    {
        public string OPERATOR_KODU { get; set; }
        public string OPERATOR_ADI { get; set; }
        public string OPERATOR_TUR_KODU { get; set; }
        public bool A_P { get; set; }
    }
}
