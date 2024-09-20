namespace ApplicationLayer.DTO.Location
{
    public class RackDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public List<ShelfDto> Shelves { get; set; } = null!;
    }
}
