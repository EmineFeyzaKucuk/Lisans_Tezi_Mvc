using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class StockInAndOut
    {
        public int Id { get; set; }
        public string FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string DEPO { get; set; }
        public string NOT { get; set; }
        public string STOK_KODU { get; set; }

        public int PARTI_NO { get; set; }
        public int GELEN_MIKTAR { get; set; }
        public int CIKAN_MIKTAR { get; set; }
        public string ISLEM_BIRIMI { get; set; }


        public DataSet dt= new DataSet();


        public DataSet depoTransferBilgisi()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("depoTransferBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }
        public void saveStockInAndOut(StockInAndOut gc)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("girisCıkısCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", gc.Id);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", gc.FIS_NO);
                sqlCmd.Parameters.AddWithValue("@pTARIH", gc.TARIH);
                sqlCmd.Parameters.AddWithValue("@pDEPO", gc.DEPO);
                sqlCmd.Parameters.AddWithValue("@pNOT", gc.NOT);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", gc.STOK_KODU);
                sqlCmd.Parameters.AddWithValue("@pPARTI_NO", gc.PARTI_NO);
                sqlCmd.Parameters.AddWithValue("@pGELEN_MIKTAR", gc.GELEN_MIKTAR);
                sqlCmd.Parameters.AddWithValue("@pCIKAN_MIKTAR", gc.CIKAN_MIKTAR);
                sqlCmd.Parameters.AddWithValue("@pISLEM_BIRIMI", gc.ISLEM_BIRIMI);
                sqlCmd.ExecuteNonQuery();
            }
        }

        public DataSet getAllStockInAndOut()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("girisCıkısCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }
        public void getStockInAndOut(string fısNo)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("girisCıkısCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", fısNo);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["gcID"];
                    this.FIS_NO = (string)readData["FIS_NO"];
                    this.TARIH = (DateTime)readData["TARIH"];
                    this.DEPO = (String)readData["DEPO"];
                    this.NOT = (String)readData["NOT"];
                    this.STOK_KODU = (String)readData["STOK_KODU"];
                    this.PARTI_NO = (int)readData["PARTI_NO"];
                    this.GELEN_MIKTAR = (int)readData["GELEN_MIKTAR"];
                    this.CIKAN_MIKTAR = (int)readData["CIKAN_MIKTAR"];
                    this.ISLEM_BIRIMI = (String)readData["ISLEM_BIRIMI"];


                }
            }

        }

        public void getStockInAndOutCode()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("fisNoUreticiGirisCıkıs", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@pResult", SqlDbType.Char, 10).Direction = ParameterDirection.Output;

                sqlCmd.ExecuteNonQuery();

                this.FIS_NO = sqlCmd.Parameters["@pResult"].Value.ToString().Trim();
            }
        }

        public void deleteStockInAndOut(string fısNo)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("girisCıkısCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", fısNo);

                sqlCmd.ExecuteNonQuery();
            }
        }






    }
}
