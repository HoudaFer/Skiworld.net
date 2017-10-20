using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class menu
    {
        public int idMenu { get; set; }
        public bool available { get; set; }
        public string name { get; set; }
        public int orderNumber { get; set; }
        public float price { get; set; }
        public Nullable<int> restaurant_idRestaurant { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual user user { get; set; }
        public virtual restaurant restaurant { get; set; }
    }
}
