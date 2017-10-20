using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class skiareatype
    {
        public skiareatype()
        {
            this.skiareas = new List<skiarea>();
        }

        public int idType { get; set; }
        public Nullable<int> difficulty { get; set; }
        public string typeArea { get; set; }
        public virtual ICollection<skiarea> skiareas { get; set; }
    }
}
