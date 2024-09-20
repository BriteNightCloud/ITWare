using ApplicationCore.DTO.Equipment;

namespace ApplicationCore.DTO.Location
{
    public class LocationBaseDto
    {
        public virtual string Name { get; } = null!;
        public string? Description { get; set; }
        public List<EquipmentDto> Equipment { get; set; } = null!;
    }
}
