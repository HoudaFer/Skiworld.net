using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiWorld.Data.Models
{
   public class match
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int idMatch { get; set; }
        public string player1 { get; set; }
        public string player2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateMatch { get; set; }
        public int? idComp { get; set; }
        public virtual competition competition { get; set; }
    }
}
