namespace ApplicationLayer.DTO.Location
{
    public class ShelfDto
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public RackDto Rack { get; set; } = null!;
    }
}
