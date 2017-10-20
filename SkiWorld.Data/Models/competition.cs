using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiWorld.Data.Models
{
    public  class competition
    {
        public competition()
        {
            this.matchs = new List<match>();

        }

        [System.ComponentModel.DataAnnotations.Key]
        public int idComp { get; set; }
        public string name { get; set; }
        public string place { get; set; }
        public virtual ICollection<match> matchs { get; set; }
    }
}
