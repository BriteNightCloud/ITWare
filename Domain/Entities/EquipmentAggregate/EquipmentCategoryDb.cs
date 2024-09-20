using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.EquipmentAggregate
{
    [Table("EquipmentCategory")]
    public class EquipmentCategoryDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
