using ApplicationCore.DTO.Location;

namespace ApplicationCore.DTO.Equipment
{
    public class EquipmentDto
    {
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
