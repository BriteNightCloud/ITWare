namespace Domain.Entities.LocationAggregate
{
    public class RackDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public virtual List<ShelfDb> Shelves { get; set; } = null!;
    }
}
