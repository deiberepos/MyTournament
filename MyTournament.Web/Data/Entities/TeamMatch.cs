using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class TeamMatch
    {
        public int Id { get; set; }
        public Team Team { get; set; }
        public Match Match { get; set; }
        public String Tipo { get; set; }
    }
}
