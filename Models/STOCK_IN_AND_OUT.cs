﻿namespace Lisans_Tezi_Mvc.Models
{
    public class STOCK_IN_AND_OUT : BaseEntity
    {

      
        public int FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string DEPO { get; set; }
        public string NOT { get; set; }
        public string STOK_KODU{ get; set; }
  
        public int PARTI_NO { get; set; }
        public int GELEN_MIKTAR { get; set; }
        public int CIKAN_MIKTAR { get; set; }
        public string ISLEM_BIRIMI { get; set; }
       
    }
}
