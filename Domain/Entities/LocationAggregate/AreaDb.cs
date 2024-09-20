using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.LocationAggregate
{
	[Table("Area")]
	public class AreaDb : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual BuildingDb Building { get; set; } = null!;
    }
}
