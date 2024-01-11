using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  UserId{ get; set; }
        [Required]
        public string FirstName { get; set; }
       // public string Password { get; set; }
        [Required]
        public string Mail { get; set; }

        //[ForeignKey("CompanyOfProfession")]
        //public int ProfessionId { get; set; }
        [MaxLength(10)]
        [MinLength(9)]
        public string Phone { get; set; }
        //    public virtual CompanyOfProfession CompanyOfProfession { get; set; }

        public override string ToString()
        {
            return FirstName;
        }

    }
}
