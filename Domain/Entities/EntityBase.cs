using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}
