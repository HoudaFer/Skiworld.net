using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkiWorld.Data.Models
{
    public partial class evenement
    {
        public evenement()
        {
            this.users = new List<user>();
            
        }
        [System.ComponentModel.DataAnnotations.Key]
        public int idEvent { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateEvent { get; set; }
        public string name { get; set; }
        public int numberGuests { get; set; }
        public string place { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual ICollection<user> users { get; set; }
        //public virtual user user { get; set; }
        
    }
}
