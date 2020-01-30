using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class Coach
    {
        public int Id { get; set; }
        public User User { get; set; }
    }
}
