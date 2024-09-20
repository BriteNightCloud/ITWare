namespace ApplicationLayer.DTO.Location
{
    public class AreaDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public BuildingDto Building { get; set; } = null!;
    }
}
