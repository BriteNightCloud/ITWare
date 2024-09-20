namespace Domain.Entities.LocationAggregate
{
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
