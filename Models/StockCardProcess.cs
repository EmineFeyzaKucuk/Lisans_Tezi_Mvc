using Microsoft.AspNetCore.Hosting;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Lisans_Tezi_Mvc.Models
{
    public class StockCardProcess
    {
        public int Id { get; set; }
        public string STOK_KODU { get; set; }
        public string STOK_ADI { get; set; }
        public int RISK_SURESI { get; set; }
        public int ZAMAN_BIRIMI { get; set; }
        public int MUHASEBE_ID { get; set; }
        public int DEPO_ID { get; set; }
        public int CARI_ID { get; set; }
        public int MIKTAR_BIRIM_ID { get; set; }
        public float MIKTAR { get; set; }
        public float BOY { get; set; }
        public float EN { get; set; }
        public float YUKSEKLIK { get; set; }
        public float SATIS_FIYAT { get; set; }
        public float SATIS_FIYAT_KDY { get; set; }
        public float ALIS_FIYAT { get; set; }
        public float ALIS_FIYAT_KDY { get; set; }

        
       public DataSet dt = new DataSet();

        public DataSet stokKartListeBilgisiGetir()
        {


            SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString);
           
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("stokKartListeBilgisiGetir", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;          

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(dt);
           

            return dt;
        
        }      
        
        public void saveStockCard(StockCardProcess stp)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokKartListeleKaydetGuncelleSil", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 1);
                sqlCmd.Parameters.AddWithValue("@pId", stp.Id);
                sqlCmd.Parameters.AddWithValue("@pSTOK_KODU", stp.STOK_KODU);
                sqlCmd.Parameters.AddWithValue("@pSTOK_ADI", stp.STOK_ADI);
                sqlCmd.Parameters.AddWithValue("@pRISK_SURESI", stp.RISK_SURESI);
                sqlCmd.Parameters.AddWithValue("@pZAMAN_BIRIMI", stp.ZAMAN_BIRIMI);
                sqlCmd.Parameters.AddWithValue("@pMUHASEBE_ID", stp.MUHASEBE_ID);
                sqlCmd.Parameters.AddWithValue("@pDEPO_ID", stp.DEPO_ID);
                sqlCmd.Parameters.AddWithValue("@pCARI_ID", stp.CARI_ID);
                sqlCmd.Parameters.AddWithValue("@pMIKTAR_BIRIM_ID", stp.MIKTAR_BIRIM_ID);
                sqlCmd.Parameters.AddWithValue("@pMIKTAR", stp.MIKTAR);
                sqlCmd.Parameters.AddWithValue("@pBOY", stp.BOY);
                sqlCmd.Parameters.AddWithValue("@pEN", stp.EN);
                sqlCmd.Parameters.AddWithValue("@pYUKSEKLIK", stp.YUKSEKLIK);
                sqlCmd.Parameters.AddWithValue("@pSATIS_FIYAT", stp.SATIS_FIYAT);
                sqlCmd.Parameters.AddWithValue("@pSATIS_FIYAT_KDY", stp.SATIS_FIYAT_KDY);
                sqlCmd.Parameters.AddWithValue("@pALIS_FIYAT", stp.ALIS_FIYAT);
                sqlCmd.Parameters.AddWithValue("@pALIS_FIYAT_KDY", stp.ALIS_FIYAT_KDY);
                sqlCmd.ExecuteNonQuery();
            }
        }


        public DataSet getAllStockCard()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokKartListeleKaydetGuncelleSil", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);

                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
            }

            return dt;

        }


        public void getStockCard(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokKartListeleKaydetGuncelleSil", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 0);
                sqlCmd.Parameters.AddWithValue("@pId", id);

                SqlDataReader readData = sqlCmd.ExecuteReader();

                if (readData.Read())
                {
                    this.Id                 = (int)readData["stkID"];
                    this.STOK_KODU          = (String)readData["STOK_KODU"]; 
                    this.STOK_ADI           = (String)readData["STOK_ADI"];
                    this.RISK_SURESI        = (int)readData["RISK_SURESI"];
                    this.ZAMAN_BIRIMI       = (int)readData["ZAMAN_BIRIMI"];
                    this.MUHASEBE_ID        = (int)readData["MUHASEBE_ID"];
                    this.DEPO_ID            = (int)readData["DEPO_ID"];
                    this.CARI_ID            = (int)readData["CARI_ID"];
                    this.MIKTAR_BIRIM_ID    = (int)readData["MIKTAR_BIRIM_ID"];
                    this.MIKTAR             = (float)(Double)readData["MIKTAR"];
                    this.BOY                = (float)(Double)readData["BOY"];
                    this.EN                 = (float)(Double)readData["EN"];
                    this.YUKSEKLIK          = (float)(Double)readData["YUKSEKLIK"];
                    this.SATIS_FIYAT        = (float)(Double)readData["SATIS_FIYAT"];
                    this.SATIS_FIYAT_KDY    = (float)(Double)readData["SATIS_FIYAT_KDY"];
                    this.ALIS_FIYAT         = (float)(Double)readData["ALIS_FIYAT"];
                    this.ALIS_FIYAT_KDY     = (float)(Double)readData["ALIS_FIYAT_KDY"];
                }
            }

        }


        public void deleteStockCard(int Id)
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("stokKartListeleKaydetGuncelleSil", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@pPorcessType", 2);
                sqlCmd.Parameters.AddWithValue("@pId", Id);

                sqlCmd.ExecuteNonQuery();

            }
        }


        public void getStockCardCode()
        {
            using (SqlConnection sqlConn = new SqlConnection(DBInfo.ConnectionString))
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("stokKodUretici", sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@pResult", SqlDbType.Char, 10).Direction = ParameterDirection.Output;

                sqlCmd.ExecuteNonQuery();

                this.STOK_KODU = sqlCmd.Parameters["@pResult"].Value.ToString().Trim();
            }
        }


    }


    [HtmlTargetElement("input", Attributes = ForAttributeName)]
    public class CustomInput : InputTagHelper
    {
        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName("asp-is-disabled")]
        public bool IsDisabled { set; get; }

        public CustomInput(IHtmlGenerator generator) : base(generator)
        {
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (IsDisabled)
            {
                var d = new TagHelperAttribute("readonly", "readonly");
                output.Attributes.Add(d);
            }
            base.Process(context, output);
        }
    }


}





