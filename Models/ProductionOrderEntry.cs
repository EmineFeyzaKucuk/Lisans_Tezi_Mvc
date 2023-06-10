using Microsoft.Data.SqlClient;
using System.Data;

namespace Lisans_Tezi_Mvc.Models
{
    public class ProductionOrderEntry
    {
        public int Id { get; set; }

        public string URETIM_EMRI_NO { get; set; }
        public DateTime TARIH { get; set; }
        public string URETIM_EMRI_VEREN { get; set; }
        public string ACIKLAMA { get; set; }
        public bool STOK_ICIN_URETIM { get; set; }
        public bool SIPARIS_ICIN_URETIM { get; set; }
        public string SIPARIS_NO { get; set; }
        public string CARI_HESAP_KODU { get; set; }
        public string STOK_KODU { get; set; }
        public int ISLEM_MIKTARI { get; set; }
        public string ISLEM_BIRIMI { get; set; }
        public DateTime IMALAT_TESLIM_TARIHI { get; set; }
        public DateTime MUSTERIYE_TESLIM_TARIHI { get; set; }

        public DataSet dt = new DataSet();


        public DataSet uretimEmriBilgisiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("uretimEmriBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }

        public void saveProductionOrderEntry(ProductionOrderEntry str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("uretimEmriGirisCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pURETIM_EMRI_NO", str.URETIM_EMRI_NO);
                sqlCmd.Parameters.AddWithValue("@pTARIH", str.TARIH);
                sqlCmd.Parameters.AddWithValue("@pURETIM_EMRI_VEREN", str.URETIM_EMRI_VEREN);
                sqlCmd.Parameters.AddWithValue("@pACIKLAMA", str.ACIKLAMA);
                sqlCmd.Parameters.AddWithValue("@pSTOK_ICIN_URETIM", str.STOK_ICIN_URETIM);
                sqlCmd.Parameters.AddWithValue("@pSIPARIS_ICIN_URETIM", str.SIPARIS_ICIN_URETIM);
                sqlCmd.Parameters.AddWithValue("@pSIPARIS_NO", str.SIPARIS_NO);
                sqlCmd.Parameters.AddWithValue("@pCARI_HESAP_KODU", str.CARI_HESAP_KODU);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", str.STOK_KODU);
                sqlCmd.Parameters.AddWithValue("@pISLEM_MIKTARI", str.ISLEM_MIKTARI);
                sqlCmd.Parameters.AddWithValue("@pISLEM_BIRIMI", str.ISLEM_BIRIMI);
                sqlCmd.Parameters.AddWithValue("@pIMALAT_TESLIM_TARIHI", str.IMALAT_TESLIM_TARIHI);
                sqlCmd.Parameters.AddWithValue("@pMUSTERIYE_TESLIM_TARIHI", str.MUSTERIYE_TESLIM_TARIHI);

                sqlCmd.ExecuteNonQuery();
            }
        }
        public DataSet getAllProductionOrderEntry()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("uretimEmriGirisCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getProductionOrderEntry(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("uretimEmriGirisCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id                         = (int)readData["Id"];
                    this.URETIM_EMRI_NO             = (String)readData["URETIM_EMRI_NO"];
                    this.TARIH                      = (DateTime)readData["TARIH"];
                    this.URETIM_EMRI_VEREN          = (string)readData["URETIM_EMRI_VEREN"];
                    this.ACIKLAMA                   = (String)readData["ACIKLAMA"];
                    this.STOK_ICIN_URETIM           = (bool)readData["STOK_ICIN_URETIM"];
                    this.SIPARIS_ICIN_URETIM        = (bool)readData["SIPARIS_ICIN_URETIM"];
                    this.SIPARIS_NO                 = (String)readData["SIPARIS_NO"];
                    this.CARI_HESAP_KODU            = (String)readData["CARI_HESAP_KODU"];
                    this.STOK_KODU                  = (String)readData["STOK_KODU"];
                    this.ISLEM_MIKTARI              = (int)readData["ISLEM_MIKTARI"];
                    this.ISLEM_BIRIMI               = (String)readData["ISLEM_BIRIMI"];
                    this.IMALAT_TESLIM_TARIHI       = (DateTime)readData["IMALAT_TESLIM_TARIHI"];
                    this.MUSTERIYE_TESLIM_TARIHI    = (DateTime)readData["MUSTERIYE_TESLIM_TARIHI"];
                    

                }
            }

        }


        public void deleteProductionOrderEntry(string uretımEmriNo)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("uretimEmriGirisCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pURETIM_EMRI_NO", uretımEmriNo);

                sqlCmd.ExecuteNonQuery();
            }
        }

    }
}
