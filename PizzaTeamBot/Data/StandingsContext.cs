using System.Data.Entity;
using System.Data.SQLite;
using PizzaTeamBot.Models;

namespace PizzaTeamBot.Data
{
    public class StandingsContext: DbContext
    {
        private StandingsContext()
        {

        }

        public DbSet<TeamMemer> TeamMembers { get; set; }
    }
}