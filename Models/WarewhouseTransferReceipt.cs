using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.Intrinsics.Arm;

namespace Lisans_Tezi_Mvc.Models
{
    public class WarewhouseTransferReceipt
    {

        public int Id { get; set; }
        public string FIS_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string GONDEREN_DEPO { get; set; }
        public string ALAN_DEPO { get; set; }
        public string STOK_KODU { get; set; }
        public int PARTI_NO { get; set; }
        public int ISLEM_MIKTARI { get; set; }
        public string ISLEM_BIRIMI { get; set; }
        public string ACIKLAMA { get; set; }


        public DataSet dt = new DataSet();


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

        public void saveWarehouseTransferReceipt(WarewhouseTransferReceipt dpt)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoTransferCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", dpt.Id);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", dpt.FIS_NO);
                sqlCmd.Parameters.AddWithValue("@pTARIH", dpt.TARIH);
                sqlCmd.Parameters.AddWithValue("@pGONDEREN_DEPO", dpt.GONDEREN_DEPO);
                sqlCmd.Parameters.AddWithValue("@pALAN_DEPO", dpt.ALAN_DEPO);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", dpt.STOK_KODU);
                sqlCmd.Parameters.AddWithValue("@pPARTI_NO", dpt.PARTI_NO);
                sqlCmd.Parameters.AddWithValue("@pISLEM_MIKTARI", dpt.ISLEM_MIKTARI);
                sqlCmd.Parameters.AddWithValue("@pISLEM_BIRIMI", dpt.ISLEM_BIRIMI);
                sqlCmd.Parameters.AddWithValue("@pACIKLAMA", dpt.ACIKLAMA);
                sqlCmd.ExecuteNonQuery();
            }
        }

        public DataSet getAllWarehouseTransferReceipt()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoTransferCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getWarehouseTransferReceiptCode(string fısNo)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoTransferCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", fısNo);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id                     = (int)readData["dptID"];
                    this.FIS_NO                 = (string)readData["FIS_NO"];
                    this.TARIH                  = (DateTime)readData["TARIH"];
                    this.GONDEREN_DEPO          = (String)readData["GONDEREN_DEPO"];
                    this.ALAN_DEPO              = (String)readData["ALAN_DEPO"];
                    this.STOK_KODU              = (String)readData["STOK_KODU"];
                    this.PARTI_NO               = (int)readData["PARTI_NO"];
                    this.ISLEM_MIKTARI          = (int)readData["ISLEM_MIKTARI"];
                    this.ISLEM_BIRIMI           = (String)readData["ISLEM_BIRIMI"];
                    this.ACIKLAMA               = (String)readData["ACIKLAMA"];


                }
            }

        }
        public void getStockTransactionRecordsCode()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("fısNoTransfer", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@pResult", SqlDbType.Char, 10).Direction = ParameterDirection.Output;

                sqlCmd.ExecuteNonQuery();

                this.FIS_NO = sqlCmd.Parameters["@pResult"].Value.ToString().Trim();
            }
        }


        public void deleteWarehouseTransferReceipt(string fısNo)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoTransferCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", fısNo);

                sqlCmd.ExecuteNonQuery();
            }
        }




    }
}
