using Lisans_Tezi_Mvc.Models;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Lisans_Tezi_Mvc.Models
{
    public class StockTransactionRecords1
    {
        public int Id { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public DateTime TARIH { get; set; }
        public string FIS_NO { get; set; }
        public decimal FIYAT { get; set; }
        public string STOK_HAREKET_DURUMU { get; set; }
        public string DEPO_KODU { get; set; }
        public string MALIYET { get; set; }
        public string ACIKLAMA { get; set; }
        public decimal MALIYET_FIYATI { get; set; }
        public int GIRIS_MIKTARI { get; set; }
        public int CIKIS_MIKTARI { get; set; }
        public decimal GIRIS_TUTARI { get; set; }
        public decimal CIKIS_TUTARI { get; set; }
        public int BAKIYE_MIKTARI { get; set; }

        public DataSet dt = new DataSet();

        public DataSet stokHareketBilgiGetir()
        {
            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("stokHareketBilgiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);


            return dt;
        }
        public void saveStockTransactionRecords(STOCK_TRANSACTION_RECORDS_ENTRY str)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokHareketCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", str.Id);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", str.STOK_KODU);
                sqlCmd.Parameters.AddWithValue("@pTARIH", str.TARIH);
                sqlCmd.Parameters.AddWithValue("@pFIS_NO", str.FIS_NO);
                sqlCmd.Parameters.AddWithValue("@pFIYAT", str.FIYAT);
                sqlCmd.Parameters.AddWithValue("@pHAREKET_DURUMU", str.STOK_HAREKET_DURUMU);
                sqlCmd.Parameters.AddWithValue("@pDEPO_KODU", str.DEPO_KODU);
                sqlCmd.Parameters.AddWithValue("@pMALIYET", str.MALIYET);
                sqlCmd.Parameters.AddWithValue("@pACIKLAMA", str.ACIKLAMA);
                sqlCmd.Parameters.AddWithValue("@pMALIYET_FIYATI", str.MALIYET_FIYATI);
                sqlCmd.Parameters.AddWithValue("@pGIRIS_MIKTARI", str.GIRIS_MIKTARI);
                sqlCmd.Parameters.AddWithValue("@pCIKIS_MIKTARI", str.CIKIS_MIKTARI);
                sqlCmd.Parameters.AddWithValue("@pGIRIS_TUTARI", str.GIRIS_TUTARI);
                sqlCmd.Parameters.AddWithValue("@pCIKIS_TUTARI", str.CIKIS_TUTARI);
                sqlCmd.Parameters.AddWithValue("@pBAKIYE MIKTARI", str.BAKIYE_MIKTARI);
                sqlCmd.ExecuteNonQuery();
            }
        }


        public DataSet getAllStockTransactionRecords()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokHareketCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }

        public void getStockTransactionRecords(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokHareketCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id = (int)readData["stkID"];
                    this.STOK_KODU = (String)readData["STOK_KODU"];
                    this.TARIH = (DateTime)readData["TARIH"];
                    this.FIS_NO = (String)readData["FIS_NO"];
                    this.FIYAT = (int)readData["FIYAT"];
                    this.STOK_HAREKET_DURUMU = (String)readData["STOK_HAREKET_DURUMU"];
                    this.DEPO_KODU = (String)readData["DEPO_KODU"];
                    this.MALIYET = (String)readData["MALIYET"];
                    this.ACIKLAMA = (String)readData["ACIKLAMA"];
                    this.MALIYET_FIYATI = (decimal)readData["MALIYET_FIYATI"];
                    this.GIRIS_MIKTARI = (int)readData["GIRIS_MIKTARI"];
                    this.CIKIS_MIKTARI = (int)readData["CIKIS_MIKTARI"];
                    this.GIRIS_TUTARI = (decimal)readData["GIRIS_TUTARI"];
                    this.CIKIS_TUTARI = (decimal)readData["CIKIS_TUTARI"];
                    this.BAKIYE_MIKTARI = (int)readData["BAKIYE_MIKTARI"];

                }
            }

        }


        public void deleteStockTransactionRecords(String stokKodu)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokHareketCRUD", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", stokKodu);

                sqlCmd.ExecuteNonQuery();
            }
        }

    }
}
