namespace ApplicationCore.Models.Location.StoredLocation
{
    public class StoredLocation : Location
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
