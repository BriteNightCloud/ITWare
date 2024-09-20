namespace Domain.Entities.EquipmentAggregate
{
    public class EquipmentCategoryDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
