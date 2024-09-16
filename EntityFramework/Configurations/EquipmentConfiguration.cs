using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations
{
	public class EquipmentConfiguration : IEntityTypeConfiguration<Equipment>
	{
		public void Configure(EntityTypeBuilder<Equipment> builder)
		{
			builder.Property(p => p.Status).HasConversion(e => e.ToString(), s => Enum.Parse<EquipmentStatus>(s));
		}
	}
}
