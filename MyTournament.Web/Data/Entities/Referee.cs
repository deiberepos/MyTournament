﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data.Entities
{
    public class Referee
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ICollection<RefereeMatch> RefereeMatches { get; set; }
    }
}
