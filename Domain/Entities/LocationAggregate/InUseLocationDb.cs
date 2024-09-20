using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.LocationAggregate
{
	[Table("Location")]
	public class InUseLocationDb : LocationBaseDb
	{
		public override string Name
		{
			get
			{
				return $"{Building.Name} - {Area.Name}";
			}
		}
		public virtual BuildingDb Building { get; set; } = null!;
		public virtual AreaDb Area { get; set; } = null!;
	}
}
