using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class restotable
    {
        public restotable()
        {
            this.restotablereservations = new List<restotablereservation>();
        }

        public int idTable { get; set; }
        public bool available { get; set; }
        public int chairsNumber { get; set; }
        public int tablesNumber { get; set; }
        public Nullable<int> restaurant_idRestaurant { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual restaurant restaurant { get; set; }
        public virtual ICollection<restotablereservation> restotablereservations { get; set; }
        public virtual user user { get; set; }
    }
}
