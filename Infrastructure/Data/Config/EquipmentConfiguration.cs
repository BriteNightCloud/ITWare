using Domain.Entities.EquipmentAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class EquipmentConfiguration : IEntityTypeConfiguration<EquipmentDb>
    {
        public void Configure(EntityTypeBuilder<EquipmentDb> builder)
        {
            builder.Property(p => p.Status).HasConversion(e => e.ToString(), s => Enum.Parse<EquipmentStatusDb>(s));
        }
    }
}
