using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{

    public class RequestTrip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodeRequest { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int NumberOfTravelers { get; set; }
        public DateTime StartDate { get; set; }
        public string Address { get; set; }
        public string AddressID { get; set; }
        public string Maill { get; set; }
        public int ThinkNumberOfTravelers { get; set; }
        public int alltravels { get; set; }
        public string Phone { get; set; } 
        public string group { get; set; }
        [ForeignKey("TripSite")]
        public int TripCode { get; set; }      
        public virtual TripSite TripSite { get; set; }
        public int CompanyOfProfessionGuard { get; set; }
        public int CompanyOfProfessionMedic { get; set; }
        public int CompanyOfProfessionTourGuide { get; set; }
        public int CompanyOfProfessionAccompanied { get; set; }
        public int NumBus { get; set; }
        public int NumMinbus { get; set; }
        public int Switch { get; set; }
        public RequestTrip()
        {
        }
    }



}
