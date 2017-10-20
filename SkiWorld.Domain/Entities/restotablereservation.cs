using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class restotablereservation
    {
        public System.DateTime endTime { get; set; }
        public int id_table { get; set; }
        public int id_user { get; set; }
        public System.DateTime startTime { get; set; }
        public virtual restotable restotable { get; set; }
        public virtual user user { get; set; }
    }
}
