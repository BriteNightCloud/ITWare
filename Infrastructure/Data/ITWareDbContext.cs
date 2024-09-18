using ApplicationCore.Entities.EquipmentAggregate;
using ApplicationCore.Entities.LocationAggregate;
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

		public DbSet<Equipment> Equipment { get; set; }
        public DbSet<BaseLocation> Locations { get; set; }
        public DbSet<InUseLocation> InUseLocations { get; set; }
        public DbSet<StoredLocation> StoredLocations { get; set; }

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
