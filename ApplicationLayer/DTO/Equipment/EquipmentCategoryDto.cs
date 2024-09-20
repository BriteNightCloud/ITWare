namespace ApplicationLayer.DTO.Equipment
{
	public class EquipmentCategoryDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Description { get; set; }
	}
}
