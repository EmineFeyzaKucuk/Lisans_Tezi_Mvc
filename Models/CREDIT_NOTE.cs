﻿namespace Lisans_Tezi_Mvc.Models
{
    public class CREDIT_NOTE: BaseEntity
    {

        public string BELGE_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string ALACAKLI_HESAP_KODU { get; set; }
        

        public string NITELIK { get; set; }
        public string ACIKLAMA { get; set; }
        public string DEKONT_TUTARI { get; set; }
        public string TOPLAM_BORC { get; set; }
    }
}
