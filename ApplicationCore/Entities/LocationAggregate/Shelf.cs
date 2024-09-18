namespace ApplicationCore.Entities.LocationAggregate
{
    public class Shelf : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public virtual Rack Rack { get; set; } = null!;
    }
}
