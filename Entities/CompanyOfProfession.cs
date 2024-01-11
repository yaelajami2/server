using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public enum CompanyKind { Guard, Medic, TourGuide, Accompanied }
    public class CompanyOfProfession
    {
       
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfessionId { get; set; }
        public string ProfessionalName { get; set; }
        [MinLength(9)]
        public string Telphone { get; set; }
        public double PriceperHour { get; set; }
        

    }
}
