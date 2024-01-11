using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class PlannedTrip
    {
      [Key]
        public int CodePlannedTrip { get; set; }
        public DateTime Date { get; set; }
     

    }
}
