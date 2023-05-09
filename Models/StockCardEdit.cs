using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;



namespace Lisans_Tezi_Mvc.Models
{
    public class StockCardEdit
    {
        public int Id { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public int RISK_SURESI { get; set; }
        public int ZAMAN_BIRIMI { get; set; }
        public int MUHASEBE_ID { get; set; }
        public int DEPO_ID { get; set; }
        public int CARI_ID { get; set; }
        public int MIKTAR_BIRIM_ID { get; set; }
        public float MIKTAR { get; set; }
        public float BOY { get; set; }
        public float EN { get; set; }
        public float YUKSEKLIK { get; set; }

        
       public DataSet dt = new DataSet();

        public DataSet stokKartListeBilgisiGetir()
        {


            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);
           
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("stokKartListeBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;          

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
           

            return dt;
        }      
        
        


    }
}





