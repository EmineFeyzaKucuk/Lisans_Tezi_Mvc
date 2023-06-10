using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class OperatorDescription
    {
        public int Id { get; set; }
        public string OPERATOR_KODU { get; set; }
        public string OPERATOR_ADI { get; set; }
        public string OPERATOR_TUR_KODU { get; set; }
        public bool A_P { get; set; }

        public DataSet dt = new DataSet();

        public DataSet operasyonBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("operatorBilgiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveOperatorDescription(OperatorDescription str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_KODU", str.OPERATOR_KODU);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_ADI", str.OPERATOR_ADI);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_TUR_KODU", str.OPERATOR_TUR_KODU);
                sqlCmd.Parameters.AddWithValue("@pA_P", str.A_P);
              
                sqlCmd.ExecuteNonQuery();
            }
        }
        public DataSet getAllOperatorDescription()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getOperatorDescription(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["Id"];
                    this.OPERATOR_KODU = (String)readData["OPERATOR_KODU"];
                    this.OPERATOR_ADI = (String)readData["OPERATOR_ADI"];
                    this.A_P = (bool)readData["A_P"];
                    this.OPERATOR_TUR_KODU = (String)readData["OPERATOR_TUR_KODU"];
                 
                }
            }

        }


        public void deleteOperatorDescription(string operatorKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_KODU", operatorKodu);

                sqlCmd.ExecuteNonQuery();
            }
        }

    }
}
