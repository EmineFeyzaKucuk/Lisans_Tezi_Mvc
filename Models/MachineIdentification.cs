using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class MachineIdentification
    {
        public int Id { get; set; }
        public string MAKINE_KODU { get; set; }
        public string MAKINE_ADI { get; set; }
        public string A_P { get; set; }
        public int MAKINE_SAYISI { get; set; }
        public string ACIKLAMA { get; set; }
        public int URETIM_SURESI { get; set; }
        public int HAZIRLIK_SURESI { get; set; }


        public DataSet dt = new DataSet();

        public DataSet makineBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("makineBilgiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveMachineIdentification(MachineIdentification str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("makineCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pMAKINE_KODU", str.MAKINE_KODU);
                sqlCmd.Parameters.AddWithValue("@pMAKINE_ADI", str.MAKINE_ADI);
                sqlCmd.Parameters.AddWithValue("@pA_P", str.A_P);
                sqlCmd.Parameters.AddWithValue("@pMAKINE_SAYISI", str.MAKINE_SAYISI);
                sqlCmd.Parameters.AddWithValue("@pACIKLAMA", str.ACIKLAMA);
                sqlCmd.Parameters.AddWithValue("@pURETIM_SURESI", str.URETIM_SURESI);
                sqlCmd.Parameters.AddWithValue("@pHAZIRLIK_SURESI", str.HAZIRLIK_SURESI);
                sqlCmd.ExecuteNonQuery();
            }
        }




        public DataSet getAllMachineIdentification()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("makineCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getMachineIdentification(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("makineCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id                             = (int)readData["Id"];
                    this.MAKINE_KODU                    = (String)readData["MAKINE_KODU"];
                    this.MAKINE_ADI                     = (String)readData["MAKINE_ADI"];
                    this.A_P                            = (String)readData["A_P"];
                    this.MAKINE_SAYISI                  = (int)readData["MAKINE_SAYISI"];
                    this.ACIKLAMA                       = (String)readData["ACIKLAMA"];
                    this.URETIM_SURESI                  = (int)readData["URETIM_SURESI"];
                    this.HAZIRLIK_SURESI                = (int)readData["HAZIRLIK_SURESI"];
                  
                  

                }
            }

        }


        public void deleteMachineIdentification(int Id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("makineCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pId", Id);

                sqlCmd.ExecuteNonQuery();
            }
        }



    }
}
