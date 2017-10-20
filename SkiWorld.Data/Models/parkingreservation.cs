using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkiWorld.Data.Models
{
    public partial class parkingreservation
    {
        public System.DateTime dateArrival { get; set; }
        public System.DateTime dateDeparture { get; set; }
       
        [Key, Column(Order = 1)]
        public int id_parking { get; set; }
        [Key, Column(Order =2)]
        public int id_user { get; set; }
        public float price { get; set; }
        public virtual parking parking { get; set; }
        public virtual user user { get; set; }
    }
}
