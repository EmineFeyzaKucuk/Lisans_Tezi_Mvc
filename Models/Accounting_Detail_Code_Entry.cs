using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices.Marshalling;

namespace Lisans_Tezi_Mvc.Models
{
    public class Accounting_Detail_Code_Entry
    {
        public int Id { get; set; }
        public int MUHASEBE_KODU { get; set; }
        public string ALIS_HESABI { get; set; }
        public string ALISTAN_IADE_HESABI { get; set; }
        public string SATIS_HESABI { get; set; }
        public string SATISTAN_IADE_HESABI { get; set; }

        public DataSet dt=new DataSet();


        public DataSet StokMuhasebeBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("StokMuhasebeBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveAccountingDetailCodeEntry(Accounting_Detail_Code_Entry mdk)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("StokMuhasebeBilgisiCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", mdk.Id);
                sqlCmd.Parameters.AddWithValue("@pMUHASEBE_KODU", mdk.MUHASEBE_KODU);
                sqlCmd.Parameters.AddWithValue("@pALIS_HESABI", mdk.ALIS_HESABI);
                sqlCmd.Parameters.AddWithValue("@pALISTAN_IADE_HESABI", mdk.ALISTAN_IADE_HESABI);
                sqlCmd.Parameters.AddWithValue("@pSATIS_HESABI", mdk.SATIS_HESABI);
                sqlCmd.Parameters.AddWithValue("@pSATISTAN_IADE_HESABI", mdk.SATISTAN_IADE_HESABI);
                sqlCmd.ExecuteNonQuery();
            }
        }

        public DataSet getAllAccountingDetailCodeEntry()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("StokMuhasebeBilgisiCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getAccountingDetailCodeEntry(int Id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("StokMuhasebeBilgisiCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", Id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["mdkID"];
                    this.MUHASEBE_KODU = (int)readData["MUHASEBE_KODU"];
                    this.ALIS_HESABI = (String)readData["ALIS_HESABI"];
                    this.ALISTAN_IADE_HESABI = (String)readData["ALISTAN_IADE_HESABI"];
                    this.SATIS_HESABI = (String)readData["SATIS_HESABI"];
                    this.SATISTAN_IADE_HESABI = (String)readData["SATISTAN_IADE_HESABI"];
                

                }
            }

        }

        public void deleteAccountingDetailCodeEntry(int muhasebeKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("StokMuhasebeBilgisiCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pMUHASEBE_KODU", muhasebeKodu);

                sqlCmd.ExecuteNonQuery();
            }
        }

    }
}
