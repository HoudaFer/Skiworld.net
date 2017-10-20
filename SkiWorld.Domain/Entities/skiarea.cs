using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class skiarea
    {
        public skiarea()
        {
            this.skiareareservations = new List<skiareareservation>();
        }

        public int idArea { get; set; }
        public string address { get; set; }
        public bool available { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public int spectatorNumber { get; set; }
        public Nullable<int> skiAreaType_idType { get; set; }
        public virtual skiareatype skiareatype { get; set; }
        public virtual ICollection<skiareareservation> skiareareservations { get; set; }
    }
}
