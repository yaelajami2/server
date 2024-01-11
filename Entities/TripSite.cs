
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Flags]
    public enum Season { אביב = 1, סתיו = 2, חורף = 4,קיץ = 8 };
    [Flags]
    public enum Audience { ילדים = 1, משפחות = 2, קבוצות = 4, זוגות = 8 }
    public enum KindTrip { רטוב = 1, יבש = 2, מסלול = 3, טבע = 4 ,אטרקציה=5,פארקים=6,מוזיאון=7}
    public  class TripSite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string Season { get; set; }
        public string Audience { get; set; }
        public string ActivityTime { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Area { get; set; }
        public string Settlement { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AddressID { get; set; }
        public string Contact { get; set; }
        public string Img { get; set; }
        public string Lengthoftrip { get; set; }
        public string KindTrip { get; set; }
    }
}
