using System;
using System.Collections.Generic;

namespace SkiWorld.Data.Models
{
    public partial class menu
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int idMenu { get; set; }
        public bool available { get; set; }
        public string name { get; set; }
        public int orderNumber { get; set; }
        public float price { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual user user { get; set; }
        public int? idRestaurant { get; set; }
        public virtual restaurant restaurant { get; set; }
    }
}
