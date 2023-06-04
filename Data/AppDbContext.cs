﻿using Lisans_Tezi_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Lisans_Tezi_Mvc.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        //*************Genel İşlemler

        public DbSet<GENERAL_MADE_OF_DEFINITION> Genel_MamulKoduTanimlama_TBL { get; set; }
        public DbSet<GENERAL_CURRENCY_DEFINITION> Genel_ParaBirimiTanimlama_TBL { get; set; }
        public DbSet<GENERAL_BARCODE_TYPE_DEFINITION> Genel_BarkodTipiTanimlama_TBL { get; set; }

        public DbSet<GENERAL_MEASUREMENT_UNIT> Genel_OlcuBirimiTanimlama_TBL { get; set; }
        
        //****************STOK****************************************************************************
        public DbSet<STOCK_INFORMATION> StokBilgisi_TBL { get; set; }
        public DbSet<ACCOUNTING_CODE_DEFINITION> MuhasebeKodTanimlama_TBL { get; set; }

        public DbSet<EMPLOYEE_DEFINITION> Personel_TBL { get; set; }

        public DbSet<ACCOUNTING_CURRENT_CARD_DEFINITION> Muhasebe_CariKartTanimlama_TBL { get; set; }
        public DbSet<WAREHOUSE_DEFINITION> DepoTanimlama_TBL { get; set; }
        public DbSet<STOCK_TRANSACTION_RECORDS_ENTRY> Stok_IslemHareketKayitlari_TBL { get; set; }
        public DbSet<GROUP_CODE_DEFINITIONS> Stok_GrupKodTanimlama_TBL { get; set; }
        public DbSet<STOCK_CARD2> StokKart2_TBL { get; set; }
        public DbSet<STOCK_CARD1> StokKart1_TBL { get; set; }
        public DbSet<ACCOUNTING_DETAILCODE_ENTRY> MuhasebeDetayKodGiris_TBL { get; set; }
        public DbSet<BARCODE_RECORDS> Stok_BarkodKayitlari_TBL { get; set; }
        public DbSet<WAREHOUSE_TRANSFER_RECEIPT> DepolarArasıTransferFisi_TBL { get; set; }
        public DbSet<STOCK_IN_AND_OUT> Stok_GirisCikis_TBL { get; set; }
     

    

        //*************ÜRETÜM*******************************************************************************

        public DbSet<MACHINE_IDENTIFICATION> Uretim_MakineTanimlama_TBL { get; set; }
        public DbSet<OPERATION_DESCRIPTION> Uretim_OperasyonTanimlama_TBL { get; set; }
        public DbSet<OPERATOR_DESCRIPTION> Uretim_OperatorTanimlama_TBL { get; set; }
        public DbSet<OPERATOR_TYPES_DESCRIPTION> Uretim_OperatorTuruTanimlama_TBL { get; set; }
        public DbSet<PRODUCT_GROUP_DEFINITIONS> Uretim_UrunGrubuTanimlamalari_TBL { get; set; }
        public DbSet<PRODUCTION_ORDER_ENTRY> Uretim_UretimEmriGiris_TBL { get; set; }
        public DbSet<PRODUCTION_RECORD> Uretim_UretimKaydi_TBL { get; set; }
        public DbSet<WORKSTATION_IDENTIFICATION> Uretim_IsIstasyonuTanimlama_TBL { get; set; }
        




    }

}
