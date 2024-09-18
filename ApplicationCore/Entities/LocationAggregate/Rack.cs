namespace ApplicationCore.Entities.LocationAggregate
{
    public class Rack : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public virtual List<Shelf> Shelves { get; set; } = null!;
    }
}
