using ApplicationCore.Entities.EquipmentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
            builder.Property(p => p.Status).HasConversion(e => e.ToString(), s => Enum.Parse<EquipmentStatus>(s));
        }
    }
}
