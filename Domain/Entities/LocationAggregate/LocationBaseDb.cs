using Domain.Entities.EquipmentAggregate;

namespace Domain.Entities.LocationAggregate
{
    public abstract class LocationBaseDb : EntityBase
    {
        public virtual string Name { get; } = null!;
        public string? Description { get; set; }
        public virtual List<EquipmentDb> Equipment { get; set; } = null!;
    }
}
