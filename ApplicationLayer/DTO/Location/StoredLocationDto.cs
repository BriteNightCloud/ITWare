namespace ApplicationLayer.DTO.Location
{
    public class StoredLocationDto : LocationBaseDto
    {
        public override string Name
        {
            get
            {
                return $"{Rack.Name} - {Shelf.Name}";
            }
        }
        public virtual RackDto Rack { get; set; } = null!;
        public virtual ShelfDto Shelf { get; set; } = null!;
    }
}