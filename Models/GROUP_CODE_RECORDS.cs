using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class GROUP_CODE_RECORDS
    {
        public int Id { get; set; }
        public string GRUP_KODU { get; set; }
        public string GRUP_ADI { get; set; }


        public DataSet dt = new DataSet();

        public DataSet GrupCodeBilgisigetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("GrupCodeBilgisigetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }


        public void getStockTransactionRecords(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("GrupCodeRecordsCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["stkID"];
                    this.GRUP_KODU = (String)readData["GRUP_KODU"];
                    this.GRUP_ADI = (String)readData["GRUP_ADI"];
                 

                }
            }

        }

        public void deleteGroupCodeRecords(String GrupKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("GrupCodeRecordsCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@GRUP_KODU", GrupKodu);

                sqlCmd.ExecuteNonQuery();

            }
        }


    }
}
