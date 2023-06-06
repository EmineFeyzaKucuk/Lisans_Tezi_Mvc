using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class StockInfo
    {
        public int Id { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }     
        

        public DataSet dt = new DataSet();
        

        public DataSet StokListeBilgisiGetir()
        {


            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("stokListeBilgiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;

        }

        public DataSet getAllStockInfo()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokListesiListele", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

    }
}
