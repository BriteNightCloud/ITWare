using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Equipment
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? NetworkName { get; set; }
        public string? Description { get; set; }
        public int Count { get; set; } = 1;
        public string? BarCode { get; set; }
        public string? SNL { get; set; }
        public string? SerialNumber { get; set; }
        public EquipmentCategory Category { get; set; } = null!;
        public EquipmentStatus Status { get; set; } = EquipmentStatus.Stored;
        public Location.Location? Location { get; set; }
    }
}
