using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class restaurant
    {
        public restaurant()
        {
            this.menus = new List<menu>();
            this.restotables = new List<restotable>();
        }

        public int idRestaurant { get; set; }
        public Nullable<System.DateTime> closeDate { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> openDate { get; set; }
        public string phone { get; set; }
        public int starRating { get; set; }
        public virtual ICollection<menu> menus { get; set; }
        public virtual ICollection<restotable> restotables { get; set; }
    }
}
