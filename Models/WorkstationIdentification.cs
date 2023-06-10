using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class WorkstationIdentification
    {
        public int Id { get; set; }

        public string ISTASYON_KODU { get; set; }
        public string ISTASYON_ADI { get; set; }
        public bool A_P { get; set; }
        public string OPERATOR_KODU { get; set; }
        public string MAKINE_KODU { get; set; }
        public int MAKINE_SAYISI { get; set; }
        public int URETIM_SURESI { get; set; }
        public int HAZIRLIK_SURESI { get; set; }


        public DataSet dt = new DataSet();

        public DataSet IstasyonBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("IstasyonBilgiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveWorkstationIdentification(WorkstationIdentification str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("IstasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pISTASYON_KODU", str.ISTASYON_KODU);
                sqlCmd.Parameters.AddWithValue("@pISTASYON_ADI", str.ISTASYON_ADI);
                sqlCmd.Parameters.AddWithValue("@pA_P", str.A_P);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_KODU", str.OPERATOR_KODU);
                sqlCmd.Parameters.AddWithValue("@pMAKINE_KODU", str.MAKINE_KODU);
                sqlCmd.Parameters.AddWithValue("@pMAKINE_SAYISI", str.MAKINE_SAYISI);
                sqlCmd.Parameters.AddWithValue("@pURETIM_SURESI", str.URETIM_SURESI);
                sqlCmd.Parameters.AddWithValue("@pHAZIRLIK_SURESI", str.HAZIRLIK_SURESI);
               
                sqlCmd.ExecuteNonQuery();
            }
        }
        public DataSet getAllWorkstationIdentification()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("IstasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getWorkstationIdentification(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("IstasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id                             = (int)readData["Id"];
                    this.ISTASYON_KODU                  = (String)readData["ISTASYON_KODU"];
                    this.ISTASYON_ADI                   = (String)readData["ISTASYON_ADI"];
                    this.A_P                            = (bool)readData["A_P"];
                    this.OPERATOR_KODU                  = (String)readData["OPERATOR_KODU"];
                    this.MAKINE_KODU                    = (string)readData["MAKINE_KODU"];
                    this.MAKINE_SAYISI                  = (int)readData["MAKINE_SAYISI"];
                    this.URETIM_SURESI                  = (int)readData["URETIM_SURESI"];
                    this.HAZIRLIK_SURESI                = (int)readData["HAZIRLIK_SURESI"];
           
            


                }
            }

        }


        public void deleteWorkstationIdentification(string ıstasyonkodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("IstasyonCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pISTASYON_KODU", ıstasyonkodu);

                sqlCmd.ExecuteNonQuery();
            }
        }


    }
}
