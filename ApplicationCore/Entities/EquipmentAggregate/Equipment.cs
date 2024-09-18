using ApplicationCore.Entities.LocationAggregate;

namespace ApplicationCore.Entities.EquipmentAggregate
{
    public class Equipment : BaseEntity
	{
        public string Name { get; set; } = null!;
        public string? NetworkName { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; } = 1;
        public string? BarCode { get; set; }
        public string? SNL { get; set; }
        public string? SerialNumber { get; set; }
        public virtual EquipmentCategory Category { get; set; } = null!;
        public EquipmentStatus Status { get; set; } = EquipmentStatus.Stored;
        public virtual BaseLocation? Location { get; set; }
    }
}
