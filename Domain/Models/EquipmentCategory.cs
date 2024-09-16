using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class EquipmentCategory
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
