using Domain.Entities.EquipmentAggregate;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.LocationAggregate
{
    [Table("Location")]
    public abstract class LocationBaseDb : EntityBase
    {
        public virtual string Name { get; } = null!;
        public string? Description { get; set; }
        public virtual List<EquipmentDb> Equipment { get; set; } = null!;
    }
}
