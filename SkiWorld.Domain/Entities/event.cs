using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class evenement 
    {
        public evenement()
        {
            this.users = new List<user>();
           
        }

        public int idEvent { get; set; }
        public Nullable<System.DateTime> dateEvent { get; set; }
        public string name { get; set; }
        public int numberGuests { get; set; }
        public string place { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual ICollection<user> users { get; set; }
        public virtual user user { get; set; }
       
    }
}
