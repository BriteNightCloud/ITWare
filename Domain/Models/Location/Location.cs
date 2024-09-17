using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Location
{
    public class Location
    {
        [Key]
        public long Id { get; set; }
        public virtual string Name { get; } = null!;
        public string? Description { get; set; }
        public virtual List<Equipment> Equipment { get; set; } = null!;
    }
}
