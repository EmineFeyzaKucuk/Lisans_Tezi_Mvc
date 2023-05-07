using Lisans_Tezi_Mvc.Data;
using Lisans_Tezi_Mvc.Repository;
using Lisans_Tezi_Mvc.Repository.AccountingCodeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.AccountingDetailCodeEntryRepo;
using Lisans_Tezi_Mvc.Repository.BarcodeTypeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.CurrencyDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.CurrentCardIdentificationRepo;
using Lisans_Tezi_Mvc.Repository.EmployeeDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.GroupCodeRecordsRepo;
using Lisans_Tezi_Mvc.Repository.StockCard1Repo;
using Lisans_Tezi_Mvc.Repository.StockCard2Repo;
using Lisans_Tezi_Mvc.Repository.StockInformationRepo;
using Lisans_Tezi_Mvc.Repository.StockTransactionRecordsRepo;
using Lisans_Tezi_Mvc.Repository.UnitofMeasureDefinitionRepo;
using Lisans_Tezi_Mvc.Repository.WarehouseDefinitionRepo;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Lisans_Tezi_Mvc
{
public class DBInfo
    {

          public static string ConnectionString { get; set; }
    }


    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnecion")

                ));
            builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<IStockInformationRepository, StockInformationRepository>();
            builder.Services.AddScoped<IAccountingCodeDefinitionRepository, AccountingCodeDefinitionRepository>();
            builder.Services.AddScoped<IEmployeeDefinitionRepository, EmployeeDefinitionRepository>();
            builder.Services.AddScoped<IWarehouseDefinitionRepository, WarehouseDefinitonRepository>();
            builder.Services.AddScoped<IBarcodeTypeDefinitionRepository, BarcodeTypeDefinitionRepository>();
            builder.Services.AddScoped<IWarehouseDefinitionRepository, WarehouseDefinitonRepository>();
            builder.Services.AddScoped<ICurrencyDefinitionRepository, CurrencyDefinitionRepository>();
            builder.Services.AddScoped<IUnitofMeasureDefinitionRepository, UnitofMeasureDefinitionRepository>();
            builder.Services.AddScoped<ICurrentCardIdentificationRepository, CurrentCardIdentificationRepository>();
            builder.Services.AddScoped<IStockCard2Repository, StockCard2Repository>();
            builder.Services.AddScoped<IGroupCodeRecordsRepository, GroupCodeRecordsRepository>();
            builder.Services.AddScoped<IStockCard1Repository, StockCard1Repository>();
            builder.Services.AddScoped<IStockTransactionRecordsRepository, StockTransactionRecordsRepository>();
            builder.Services.AddScoped<IAccountingDetailCodeEntryRepository, AccountingDetailCodeEntryRepository>();


            DBInfo.ConnectionString = builder.Configuration["ConnectionStrings:DefaultConnecion"];


            var app = builder.Build();

            

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}