using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

 public   class Participants
    {
        [Key]
        [Column (Order =1)]
        [ForeignKey("PlanTrip")]
        public int ParticipantId { get; set; }
        public virtual PlannedTrip PlanTrip { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("ReqTrip")]
        public int CodeRequest { get; set; }
        public virtual RequestTrip ReqTrip { get; set; }

    }

}
