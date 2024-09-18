namespace ApplicationCore.Entities.LocationAggregate
{
    public class Building : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual List<Area> Areas { get; set; } = null!;
    }
}
