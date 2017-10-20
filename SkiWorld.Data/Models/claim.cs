using System;
using System.Collections.Generic;

namespace SkiWorld.Data.Models
{
    public partial class claim
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int idClaim { get; set; }
        public string description { get; set; }
        public string typeClaim { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual user user { get; set; }
    }
}
