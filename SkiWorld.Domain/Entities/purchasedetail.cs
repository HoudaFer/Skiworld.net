using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class purchasedetail
    {
        public int id_product { get; set; }
        public int id_user { get; set; }
        public System.DateTime purchaseDate { get; set; }
        public int quantity { get; set; }
        public virtual product product { get; set; }
        public virtual user user { get; set; }
    }
}
