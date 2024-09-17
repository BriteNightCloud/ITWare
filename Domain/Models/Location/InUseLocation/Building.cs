using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Location.InUseLocation
{
    public class Building
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public virtual List<Area> Areas { get; set; } = null!;
    }
}
