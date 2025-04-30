using BusinessLayer.DependencyInjection;
using DataLayer.DataAccess;
using DataLayer.DependencyInjection;
using DataLayer.Fakers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation.Froms;
using Serilog;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         
            var host = CreateHostBuilder().Build();
            Log.Information("Iniciando la aplicación...");


            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                DbSeeder.SeedInitial(dbContext);
            }

            var formService = host.Services.GetRequiredService<frmMainContainer>();
            Application.Run(formService);
            Log.CloseAndFlush();
        }

        static IHostBuilder CreateHostBuilder() =>
            Host
            .CreateDefaultBuilder()
             .UseSerilog((context, services, configuration) =>
              {
                  try
                  {
                      configuration
                          .ReadFrom.Configuration(context.Configuration)
                          .ReadFrom.Services(services)
                          .Enrich.FromLogContext();                                        }
                  catch (Exception ex)
                  {
                      Console.WriteLine($"Error al configurar Serilog: {ex.Message}");
                  }
              })
            .ConfigureAppConfiguration((context, config) =>
            {
                config
                .SetBasePath(Directory.GetCurrentDirectory())                
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection"),
                   sqlServerOptionsAction: sqlOptions =>
                   {
                       sqlOptions.EnableRetryOnFailure();
                   }));

                services.AddAutoMapperService();

                services.RegisterRepositoryDependecies();
                services.RegisterServiceDependecies();

                services.AddTransient<Form1>();
                services.AddTransient<frmCustomer>();
                services.AddTransient<frmService>();
                services.AddTransient<frmSearchService>();
                services.AddTransient<frmContract>();
                services.AddTransient<frmMainContainer>();
            });
    }
}