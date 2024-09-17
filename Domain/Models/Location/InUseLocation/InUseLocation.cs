namespace Domain.Models.Location.InUseLocation
{
    public class InUseLocation : Location
    {
        public override string Name
        {
            get
            {
                return $"{Building.Name} - {Area.Name}";
            }
        }
        public Building Building { get; set; } = null!;
        public Area Area { get; set; } = null!;
    }
}
