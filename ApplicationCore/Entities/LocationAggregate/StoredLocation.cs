namespace ApplicationCore.Entities.LocationAggregate
{
    public class StoredLocation : BaseLocation
    {
        public override string Name
        {
            get
            {
                return $"{Rack.Name} - {Shelf.Name}";
            }
        }
        public virtual Rack Rack { get; set; } = null!;
        public virtual Shelf Shelf { get; set; } = null!;
    }
}
