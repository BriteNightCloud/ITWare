namespace Domain.Entities.LocationAggregate
{
    public class ShelfDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public virtual RackDb Rack { get; set; } = null!;
    }
}
