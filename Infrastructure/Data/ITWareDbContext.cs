using ApplicationCore.Models;
using ApplicationCore.Models.Location;
using ApplicationCore.Models.Location.InUseLocation;
using ApplicationCore.Models.Location.StoredLocation;
using Castle.Core.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ITWareDbContext : DbContext
    {
		public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<InUseLocation> InUseLocations { get; set; }
        public DbSet<StoredLocation> StoredLocations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlite("Data Source=sqlite.db"); // TODO: Get Connection string from Configuration
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITWareDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
