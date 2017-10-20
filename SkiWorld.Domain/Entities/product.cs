using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class product
    {
        public product()
        {
            this.purchasedetails = new List<purchasedetail>();
        }

        public int idProduct { get; set; }
        public bool isAvailable { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public Nullable<int> Category_Fk { get; set; }
        public virtual category category { get; set; }
        public virtual ICollection<purchasedetail> purchasedetails { get; set; }
    }
}
