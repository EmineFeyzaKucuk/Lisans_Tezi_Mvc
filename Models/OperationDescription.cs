using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class OperationDescription
    {
        public int Id { get; set; }
        public string OPERASYON_KODU { get; set; }
        public string OPERASYON_ADI { get; set; }
        public bool A_P { get; set; }
        public string NORMAL_IS_GUNLERI { get; set; }
        public string CUMARTESI { get; set; }
        public string PAZAR { get; set; }
        public string HAFTALIK_KAPASITE { get; set; }
        public int KAPASITE { get; set; }
        public string OPERASYON_ACIKLAMA { get; set; }


        public DataSet dt = new DataSet();


        public DataSet operasyonBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("operasyonBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveOperationDescription(OperationDescription str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pOPERASYON_KODU", str.OPERASYON_KODU);
                sqlCmd.Parameters.AddWithValue("@pOPERASYON_ADI", str.OPERASYON_ADI);
                sqlCmd.Parameters.AddWithValue("@pA_P", str.A_P);
                sqlCmd.Parameters.AddWithValue("@pNORMAL_IS_GUNLERI", str.NORMAL_IS_GUNLERI);
                sqlCmd.Parameters.AddWithValue("@pCUMARTESI", str.CUMARTESI);
                sqlCmd.Parameters.AddWithValue("@pPAZAR", str.PAZAR);
                sqlCmd.Parameters.AddWithValue("@pHAFTALIK_KAPASITE", str.HAFTALIK_KAPASITE);
                sqlCmd.Parameters.AddWithValue("@pKAPASITE", str.KAPASITE);
                sqlCmd.Parameters.AddWithValue("@pOPERASYON_ACIKLAMA", str.OPERASYON_ACIKLAMA);
                sqlCmd.ExecuteNonQuery();
            }
        }
        public DataSet getAllOperationDescription()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getOperationDescription(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 3);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id         = (int)readData["Id"];
                    this.OPERASYON_KODU = (String)readData["OPERASYON_KODU"];
                    this.OPERASYON_ADI = (String)readData["OPERASYON_ADI"];
                    this.A_P = (bool)readData["A_P"];
                    this.NORMAL_IS_GUNLERI = (String)readData["NORMAL_IS_GUNLERI"];
                    this.CUMARTESI = (String)readData["CUMARTESI"];
                    this.PAZAR = (String)readData["PAZAR"];
                    this.HAFTALIK_KAPASITE = (String)readData["HAFTALIK_KAPASITE"];
                    this.KAPASITE = (int)readData["KAPASITE"];
                    this.OPERASYON_ACIKLAMA = (String)readData["OPERASYON_ACIKLAMA"];



                }
            }

        }


        public void deleteOperationDescription(string operasyonkodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pOPERASYON_KODU", operasyonkodu);

                sqlCmd.ExecuteNonQuery();
            }
        }



    }
}
