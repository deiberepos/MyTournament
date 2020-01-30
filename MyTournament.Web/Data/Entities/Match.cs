using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class Match
    {
        public int id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public Stadium Stadium { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
        public ICollection<RefereeMatch> RefereeMatches { get; set; }
        public ICollection<TeamMatch> TeamMatches { get; set; }

    }
}
