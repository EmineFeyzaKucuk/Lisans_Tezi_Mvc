using Lisans_Tezi_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Lisans_Tezi_Mvc.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<STOCK_INFORMATION> STOCK_INFORMATION_TBL { get; set; }


    }

}
