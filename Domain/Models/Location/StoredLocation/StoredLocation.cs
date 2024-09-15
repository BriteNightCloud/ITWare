namespace Domain.Models.Location.StoredLocation
{
    public class StoredLocation : Location
    {
        public new string Name
        {
            get
            {
                return $"{Rack.Name} - {Shelf.Name}";
            }
        }
        public Rack Rack { get; set; } = null!;
        public Shelf Shelf { get; set; } = null!;
    }
}
