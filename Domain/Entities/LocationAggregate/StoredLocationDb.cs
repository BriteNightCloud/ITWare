using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.LocationAggregate
{
	[Table("Location")]
	public class StoredLocationDb : LocationBaseDb
	{
		public override string Name
		{
			get
			{
				return $"{Rack.Name} - {Shelf.Name}";
			}
		}
		public virtual RackDb Rack { get; set; } = null!;
		public virtual ShelfDb Shelf { get; set; } = null!;
	}
}