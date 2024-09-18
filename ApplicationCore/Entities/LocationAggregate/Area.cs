namespace ApplicationCore.Entities.LocationAggregate
{
    public class Area : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual Building Building { get; set; } = null!;
    }
}
