using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Location.StoredLocation
{
    public class Rack
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public virtual List<Shelf> Shelves { get; set; } = null!;
    }
}
