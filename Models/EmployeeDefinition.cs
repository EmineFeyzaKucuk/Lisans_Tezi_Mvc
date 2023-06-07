using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class EmployeeDefinition
    {

        public int Id { get; set; }
        public string PERSONEL_ISIM { get; set; }
        public string ADRES { get; set; }
        public string POSTA_KODU { get; set; }
        public string GSM { get; set; }
        public string E_POSTA { get; set; }

        public DataSet dt = new DataSet();


        public DataSet PersonelBilgisi()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("personelBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveEmployeeDefinition(EmployeeDefinition ed)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("personelCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", ed.Id);
                sqlCmd.Parameters.AddWithValue("@pPERSONEL_ISIM", ed.PERSONEL_ISIM);
                sqlCmd.Parameters.AddWithValue("@pADRES", ed.ADRES);
                sqlCmd.Parameters.AddWithValue("@pPOSTA_KODU", ed.POSTA_KODU);
                sqlCmd.Parameters.AddWithValue("@pGSM", ed.GSM);
                sqlCmd.Parameters.AddWithValue("@pE_POSTA", ed.E_POSTA);               
                sqlCmd.ExecuteNonQuery();
            }
        }

        public DataSet getAllEmployeeDefinition()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("personelCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }
        public void getEmployeeDefinition(int Id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("personelCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", Id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["Id"];
                    this.PERSONEL_ISIM = (string)readData["PERSONEL_ISIM"];
                    this.ADRES = (String)readData["ADRES"];
                    this.POSTA_KODU = (String)readData["POSTA_KODU"];
                    this.GSM = (String)readData["GSM"];
                    this.E_POSTA = (String)readData["E_POSTA"];         


                }
            }

        }

        public void deleteEmployeeDefinition(int Id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("personelCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pId", Id);

                sqlCmd.ExecuteNonQuery();
            }
        }



    }
}
