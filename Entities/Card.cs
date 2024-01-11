using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
 public   class Card
    {
        //לשאול
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardCod { get; set; }
        public string CardNumber { get; set; }
        [MaxLength(3)]
        public string CVV { get; set; }
        public DateTime Date { get; set; }
    }
}
