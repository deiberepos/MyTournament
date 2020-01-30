using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class Team
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public String Name { get; set; }
        public Coach Coach { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<TeamMatch> TeamMatches { get; set; }
    }
}
