using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class planing
    {
        public int idPlaning { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Nullable<int> instructor_idUser { get; set; }
        public virtual user user { get; set; }
    }
}
