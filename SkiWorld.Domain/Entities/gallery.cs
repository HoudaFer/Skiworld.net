using System;
using System.Collections.Generic;

namespace SkiWorld.Domain
{
    public partial class gallery
    {
        public string DTYPE { get; set; }
        public int idGallery { get; set; }
        public Nullable<System.DateTime> addedDate { get; set; }
        public string description { get; set; }
        public string video { get; set; }
        public string picture { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual user user { get; set; }
    }
}
