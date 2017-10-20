using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class room
    {
        public room()
        {
            this.roomreservations = new List<roomreservation>();
        }

        public int idRoom { get; set; }
        public int numberRoom { get; set; }
        public Nullable<int> roomType { get; set; }
        public Nullable<int> hotel_idHotel { get; set; }
        public virtual hotel hotel { get; set; }
        public virtual ICollection<roomreservation> roomreservations { get; set; }
    }
}
