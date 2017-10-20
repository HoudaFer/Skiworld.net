using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class parking
    {
        public parking()
        {
            this.parkingreservations = new List<parkingreservation>();
        }

        public int idParking { get; set; }
        public int placeNumber { get; set; }
        public virtual ICollection<parkingreservation> parkingreservations { get; set; }
    }
}
