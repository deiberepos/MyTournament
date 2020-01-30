using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class RefereeMatch
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public String Cargo { get; set; }
        public Referee Referee { get; set; }
        public Match Match { get; set; }
    }
}
