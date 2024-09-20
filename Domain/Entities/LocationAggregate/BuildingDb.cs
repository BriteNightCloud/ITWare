using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.LocationAggregate
{
    [Table("Building")]
    public class BuildingDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual List<AreaDb> Areas { get; set; } = null!;
    }
}
