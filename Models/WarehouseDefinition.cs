using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class WarehouseDefinition
    {
        public int Id { get; set; }
        public int DEPO_KODU { get; set; }
        public string DEPO_ADI { get; set; }

        public bool E_TICARET { get; set; }
        public string TESIS_KODU { get; set; }
        public string LOKASYON_KODU { get; set; }

        public string PERSONEL_ID { get; set; }
        public string PERSONEL_IS { get; set; }


        public DataSet dt= new DataSet();


        public DataSet DepoBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("depobilgigetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }


        public void saveWarehouseDefinition(WarehouseDefinition dp)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", dp.Id);
                sqlCmd.Parameters.AddWithValue("@pDEPO_KODU", dp.DEPO_KODU);
                sqlCmd.Parameters.AddWithValue("@pDEPO_ADI", dp.DEPO_ADI);
                sqlCmd.Parameters.AddWithValue("@pE_TICARET", dp.E_TICARET);
                sqlCmd.Parameters.AddWithValue("@pTESIS_KODU", dp.TESIS_KODU);
                sqlCmd.Parameters.AddWithValue("@pLOKASYON_KODU", dp.LOKASYON_KODU);
                sqlCmd.Parameters.AddWithValue("@pPERSONEL_ID", dp.PERSONEL_ID);
                sqlCmd.Parameters.AddWithValue("@pPERSONEL_IS", dp.PERSONEL_IS);
                sqlCmd.ExecuteNonQuery();
            }
        }

        public DataSet getAllWarehouseDefinition()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }
        public void getWarehouseDefinition(int Id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", Id); 

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id                         = (int)readData["dpID"];
                    this.DEPO_KODU                  = (int)readData["DEPO_KODU"];
                    this.DEPO_ADI                   = (String)readData["DEPO_ADI"];
                    this.E_TICARET                  = (bool)readData["E_TICARET"];
                    this.TESIS_KODU                 = (String)readData["TESIS_KODU"];
                    this.LOKASYON_KODU              = (String)readData["LOKASYON_KODU"];
                    this.PERSONEL_ID                = (string)readData["PERSONEL_ID"];
                    this.PERSONEL_IS                = (String)readData["PERSONEL_IS"];


                }
            }

        }

        public void deleteWarehouseDefinition(int depoKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("depoCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pDEPO_KODU", depoKodu);

                sqlCmd.ExecuteNonQuery();
            }
        }







    }
}
