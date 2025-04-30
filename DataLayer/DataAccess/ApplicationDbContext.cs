

using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceLocation> ServiceLocations { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceSetting> ServiceSettings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractDetail> ContractDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            // Seeding para la tabla typo de servicios
            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType { Id = 1, Name = "Cable", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
                new ServiceType { Id = 2, Name = "Internet", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) }
            );

            // Seeding para la tabla configuraciones
            modelBuilder.Entity<ServiceSetting>().HasData(
                new ServiceSetting { Id = 1, Name = "Velocidad 15Mbps", Description = "Velocidad de internet", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
                new ServiceSetting { Id = 2, Name = "Velocidad 25Mbps", Description = "Velocidad de internet", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
                new ServiceSetting { Id = 3, Name = "Velocidad 50Mbps", Description = "Velocidad de internet", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
                new ServiceSetting { Id = 4, Name = "Basico 100 canales", Description = "Servicio de cable", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
                new ServiceSetting { Id = 5, Name = "Premium canales adicionaels", Description = "Servicio de cable", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) }
            );

            // Seeding para la tabla ubicaciones de servicio
            modelBuilder.Entity<ServiceLocation>().HasData(
               new ServiceLocation { Id = 1, City = "Guatemala", Zone = "1", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 2, City = "Guatemala", Zone = "2", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 3, City = "Guatemala", Zone = "3", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 4, City = "Guatemala", Zone = "4", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 5, City = "Guatemala", Zone = "5", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 6, City = "Guatemala", Zone = "6", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 7, City = "Guatemala", Zone = "7", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 8, City = "Guatemala", Zone = "8", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 9, City = "Guatemala", Zone = "9", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) },
               new ServiceLocation { Id = 10, City = "Guatemala", Zone = "10", IsActive = true, CreatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local), UpdatedAt = new DateTime(2025, 04, 28, 10, 35, 0, DateTimeKind.Local) }
            );
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entry in entries)
            {
                DateTime now = DateTime.UtcNow; // Recomiendo usar UTC para evitar problemas de zona horaria

                if (entry.State == EntityState.Added)
                {
                    entry.Property(nameof(BaseEntity.CreatedAt)).CurrentValue = now;
                    entry.Property(nameof(BaseEntity.UpdatedAt)).CurrentValue = now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property(nameof(BaseEntity.UpdatedAt)).CurrentValue = now;
                    // Para evitar reescribir la fecha de creación en modificaciones,
                    // puedes verificar si la propiedad CreatedAt ya tiene un valor.
                    if (entry.Property(nameof(BaseEntity.CreatedAt)).IsModified == false)
                    {
                        entry.Property(nameof(BaseEntity.CreatedAt)).CurrentValue = entry.Property(nameof(BaseEntity.CreatedAt)).OriginalValue;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}
