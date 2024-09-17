using Domain.Models;
using Domain.Models.Location;
using Domain.Models.Location.InUseLocation;
using Domain.Models.Location.StoredLocation;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
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
            optionsBuilder.UseSqlite("Data Source=sqlite.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITWareDbContext).Assembly);

			Database.Migrate();
			base.OnModelCreating(modelBuilder);
        }
    }
}
