using Domain.Entities.LocationAggregate;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.EquipmentAggregate
{
	[Table("Equipment")]
	public class EquipmentDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? NetworkName { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; } = 1;
        public string? BarCode { get; set; }
        public string? SNL { get; set; }
        public string? SerialNumber { get; set; }
        public virtual EquipmentCategoryDb Category { get; set; } = null!;
        public EquipmentStatusDb Status { get; set; } = EquipmentStatusDb.Stored;
        public virtual LocationBaseDb? Location { get; set; }
    }
}
