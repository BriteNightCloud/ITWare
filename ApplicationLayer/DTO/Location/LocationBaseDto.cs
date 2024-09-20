using ApplicationLayer.DTO.Equipment;

namespace ApplicationLayer.DTO.Location
{
    public class LocationBaseDto
    {
        public virtual string Name { get; } = null!;
        public string? Description { get; set; }
        public List<EquipmentDto> Equipment { get; set; } = null!;
    }
}
