using ApplicationLayer.DTO.Location;

namespace ApplicationLayer.DTO.Equipment
{
	public class EquipmentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? NetworkName { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; }
        public string? BarCode { get; set; }
        public string? SNL { get; set; }
        public string? SerialNumber { get; set; }
        public EquipmentCategoryDto Category { get; set; } = null!;
        public EquipmentStatusDto Status { get; set; }
        public LocationBaseDto? Location { get; set; }
    }
}
