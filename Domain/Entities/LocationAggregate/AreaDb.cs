namespace Domain.Entities.LocationAggregate
{
    public class AreaDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual BuildingDb Building { get; set; } = null!;
    }
}
