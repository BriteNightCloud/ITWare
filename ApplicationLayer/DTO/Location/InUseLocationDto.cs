namespace ApplicationLayer.DTO.Location
{
    public class InUseLocationDto : LocationBaseDto
    {
        public override string Name
        {
            get
            {
                return $"{Building.Name} - {Area.Name}";
            }
        }
        public virtual BuildingDto Building { get; set; } = null!;
        public virtual AreaDto Area { get; set; } = null!;
    }
}
