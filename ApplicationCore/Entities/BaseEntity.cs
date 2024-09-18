using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities
{
	public abstract class BaseEntity
	{
		[Key]
		public virtual Guid Id { get; protected set; }
	}
}
