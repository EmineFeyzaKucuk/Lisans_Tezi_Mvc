using Lisans_Tezi_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Lisans_Tezi_Mvc.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<STOCK_INFORMATION> StokBilgisi_TBL { get; set; }
        public DbSet<ACCOUNTING_CODE_DEFINITION> MuhasebeKodTanimlama_TBL { get; set; }

        public DbSet<EMPLOYEE_DEFINITION> Personel_TBL { get; set; }

        public DbSet<WAREHOUSE_DEFINITION> DepoTanimlama_TBL { get; set; }
        public DbSet<STOCK_CARD1> StokKart1_TBL { get; set; }


    }

}
