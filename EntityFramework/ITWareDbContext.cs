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
        public DbSet<InUseLocation> InUseLocations { get; set; }
		public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sqlite.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITWareDbContext).Assembly);
			modelBuilder.Entity<Location>().HasDiscriminator<string>(typeof(Location).Name)
				.HasValue<StoredLocation>(typeof(StoredLocation).Name)
				.HasValue<InUseLocation>(typeof(InUseLocation).Name);

			modelBuilder.Entity<Equipment>().Navigation(e => e.Category).AutoInclude();
			modelBuilder.Entity<Equipment>().Navigation(e => e.Location).AutoInclude();
            modelBuilder.Entity<StoredLocation>().Navigation(e => e.Rack).AutoInclude();
            modelBuilder.Entity<StoredLocation>().Navigation(e => e.Shelf).AutoInclude();
            modelBuilder.Entity<InUseLocation>().Navigation(e => e.Area).AutoInclude();
            modelBuilder.Entity<InUseLocation>().Navigation(e => e.Building).AutoInclude();

			Database.Migrate();
			base.OnModelCreating(modelBuilder);
        }
    }
}
