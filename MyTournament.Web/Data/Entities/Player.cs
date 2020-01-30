using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ICollection<Statistic> Statistics { get; set; }
        public Team Team { get; set; }

    }
}
