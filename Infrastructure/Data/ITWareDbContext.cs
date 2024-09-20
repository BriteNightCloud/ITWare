using Domain.Entities.EquipmentAggregate;
using Domain.Entities.LocationAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
    public class ITWareDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ITWareDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<EquipmentDb> Equipment { get; set; }
        public DbSet<LocationBaseDb> Locations { get; set; }
        public DbSet<InUseLocationDb> InUseLocations { get; set; }
        public DbSet<StoredLocationDb> StoredLocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlite(_configuration["ConnectionString"]);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITWareDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
