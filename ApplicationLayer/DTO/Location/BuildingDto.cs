namespace ApplicationLayer.DTO.Location
{
    public class BuildingDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public List<AreaDto> Areas { get; set; } = null!;
    }
}
