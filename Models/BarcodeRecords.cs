using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Lisans_Tezi_Mvc.Models
{
    public class BarcodeRecords
    {
        public int Id { get; set; }
        public String  STOK_KODU{ get; set; }
        public int BARKOD { get; set; }
        public string ACIKLAMA { get; set; }
        public DateTime KAYIT_TARIHI { get; set; }
        public string BARKOD_TIPI { get; set; }
        public string OLCU_BIRIMI_KODU { get; set; }



        public DataSet dt= new DataSet();

        public DataSet barkodBilgisiGetir()
        {


            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("barkodBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;

        }

        public void saveBarcodeRecords(BarcodeRecords sbk)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("barkodCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", sbk.Id);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", sbk.STOK_KODU);
                sqlCmd.Parameters.AddWithValue("@pBARKOD", sbk.BARKOD);
                sqlCmd.Parameters.AddWithValue("@pKAYIT_TARIHI", sbk.KAYIT_TARIHI);
                sqlCmd.Parameters.AddWithValue("@pBARKOD_TIPI", sbk.BARKOD_TIPI);
                sqlCmd.Parameters.AddWithValue("@pOLCU_BIRIMI_KODU", sbk.OLCU_BIRIMI_KODU);
           
                sqlCmd.ExecuteNonQuery();
            }
        }

        public DataSet getAllBarcodeRecords()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("barkodCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getBarcodeRecords(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("barkodCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["sbkID"];
                    this.STOK_KODU = (string)readData["STOK_KODU"];
                    this.BARKOD = (int)readData["BARKOD"];
                    this.KAYIT_TARIHI = (DateTime)readData["KAYIT_TARIHI"];
                    this.BARKOD_TIPI = (string)readData["BARKOD_TIPI"];
                    this.OLCU_BIRIMI_KODU = (string)readData["OLCU_BIRIMI_KODU"];
                  
                
                }
            }

        }

        public void deleteBarcodeRecords(string stokKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("barkodCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", STOK_KODU);

                sqlCmd.ExecuteNonQuery();

            }
        }

    }
}

