using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum vehicleType{ אוטבוס,מניבוס}
     public  class TripPrice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CodeTravel { get; set; }
        public string vehicleType { get; set; }
        public int Numberofseats { get; set; }
        public int Priceperkilometer { get; set; }
        public int Mintravels { get; set; }
    }
}
