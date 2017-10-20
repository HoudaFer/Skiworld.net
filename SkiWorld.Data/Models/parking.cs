using System;
using System.Collections.Generic;

namespace SkiWorld.Data.Models
{
    public partial class parking
    {
        public parking()
        {
            this.parkingreservations = new List<parkingreservation>();
        }
        [System.ComponentModel.DataAnnotations.Key]

        public int idParking { get; set; }
        public int placeNumber { get; set; }
        public virtual ICollection<parkingreservation> parkingreservations { get; set; }
    }
}
