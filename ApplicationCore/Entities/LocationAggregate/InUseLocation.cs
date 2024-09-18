namespace ApplicationCore.Entities.LocationAggregate
{
    public class InUseLocation : BaseLocation
    {
        public override string Name
        {
            get
            {
                return $"{Building.Name} - {Area.Name}";
            }
        }
        public virtual Building Building { get; set; } = null!;
        public virtual Area Area { get; set; } = null!;
    }
}
