using Domain.Models.EquipmentCategory;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Equipment
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? NetworkName { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? BarCode { get; set; }
        public string? SNL { get; set; }
        public string? SerialNumber { get; set; }
        public Category Category { get; set; } = null!;
        public EquipmentStatus Status { get; set; }
        public Location.Location? Location { get; set; }
    }
}
