using System.Collections.Generic;
using System.Data.Entity;

namespace Tournaments.Models
{
    public interface ITournamentsDbContext
    {
        DbSet<Team> Teams { get; set; }
        DbSet<Tournament> Tournaments { get; set; }
    }
}
