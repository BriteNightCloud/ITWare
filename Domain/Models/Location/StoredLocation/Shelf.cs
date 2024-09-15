﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models.Location.StoredLocation
{
    public class Shelf
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string BarCode { get; set; } = null!;
        public Rack Rack { get; set; } = null!;
    }
}
