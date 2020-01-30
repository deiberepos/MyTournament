using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTournament.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTournament.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        DbSet<Coach> Coaches { get; set; }
        DbSet<Manager> Managers { get; set; }
        DbSet<Match> Matches { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Referee> Referees { get; set; }
        DbSet<RefereeMatch> RefereeMatches { get; set; }
        DbSet<Stadium> Stadiums { get; set; }
        DbSet<Statistic> Statistics { get; set; }
        DbSet<StatisticType> StatisticTypes { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<TeamMatch> TeamMatches { get; set; }
    }
}
