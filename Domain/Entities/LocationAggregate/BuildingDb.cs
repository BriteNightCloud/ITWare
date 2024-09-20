namespace Domain.Entities.LocationAggregate
{
    public class BuildingDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual List<AreaDb> Areas { get; set; } = null!;
    }
}
