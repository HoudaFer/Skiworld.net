using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class parkingreservation
    {
        public System.DateTime dateArrival { get; set; }
        public System.DateTime dateDeparture { get; set; }
        public int id_parking { get; set; }
        public int id_user { get; set; }
        public float price { get; set; }
        public virtual parking parking { get; set; }
        public virtual user user { get; set; }
    }
}
