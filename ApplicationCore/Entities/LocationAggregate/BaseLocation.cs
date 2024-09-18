using ApplicationCore.Entities.EquipmentAggregate;

namespace ApplicationCore.Entities.LocationAggregate
{
    public abstract class BaseLocation : BaseEntity
    {
        public virtual string Name { get; } = null!;
        public string? Description { get; set; }
        public virtual List<Equipment> Equipment { get; set; } = null!;
    }
}
