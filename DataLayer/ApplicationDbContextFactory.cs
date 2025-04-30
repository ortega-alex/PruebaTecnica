using DataLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataLayer
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
             IConfigurationRoot configuration = new ConfigurationBuilder()
                  //.SetBasePath(Directory.GetCurrentDirectory())
                 .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Presentation"))
                 .AddJsonFile("appsettings.json")
                 .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
                 
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("DataLayer"));

            return new ApplicationDbContext(optionsBuilder.Options);

        }
    }
}
