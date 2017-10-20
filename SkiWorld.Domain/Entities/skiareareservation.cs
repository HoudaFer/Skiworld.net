using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class skiareareservation
    {
        public int id_skiArea { get; set; }
        public int id_user { get; set; }
        public System.DateTime reservationDate { get; set; }
        public virtual skiarea skiarea { get; set; }
        public virtual user user { get; set; }
    }
}
