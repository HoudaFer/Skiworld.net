using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class roomreservation
    {
        public System.DateTime arrivalDate { get; set; }
        public System.DateTime departureDate { get; set; }
        public int id_room { get; set; }
        public int id_user { get; set; }
        public bool isCheck { get; set; }
        public float price { get; set; }
        public Nullable<int> roomReservationType { get; set; }
        public virtual room room { get; set; }
        public virtual user user { get; set; }
    }
}
