using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class OperatorTypesDescription
    {
        public int Id { get; set; }
        public string OPERATOR_TUR_KODU { get; set; }
        public string OPERATOR_TUR_ADI { get; set; }
        public bool A_P { get; set; }


        public DataSet dt = new DataSet();

        public DataSet operatorTurBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("operatorTurBilgisi", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveOperatorTypesDescription(OperatorTypesDescription str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorTurTanimlamaCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_TUR_KODU", str.OPERATOR_TUR_KODU);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_TUR_ADI", str.OPERATOR_TUR_ADI);
                sqlCmd.Parameters.AddWithValue("@pA_P", str.A_P);                
                sqlCmd.ExecuteNonQuery();
            }
        }




        public DataSet getAllOperatorTypesDescription()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorTurTanimlamaCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getOperatorTypesDescription(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorTurTanimlamaCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 3);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["Id"];
                    this.OPERATOR_TUR_KODU = (String)readData["OPERATOR_TUR_KODU"];
                    this.OPERATOR_TUR_ADI = (String)readData["OPERATOR_TUR_ADI"];
                    this.A_P = (bool)readData["A_P"];                 



                }
            }

        }


        public void deleteOperatorTypesDescription(string operatorTurKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("operatorTurTanimlamaCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pOPERATOR_TUR_KODU", operatorTurKodu);

                sqlCmd.ExecuteNonQuery();
            }
        }


    }

}
