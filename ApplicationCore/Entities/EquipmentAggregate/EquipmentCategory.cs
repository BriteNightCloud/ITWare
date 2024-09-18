namespace ApplicationCore.Entities.EquipmentAggregate
{
    public class EquipmentCategory : BaseEntity
	{
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
