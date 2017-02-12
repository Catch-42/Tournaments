using System.Collections.Generic;
using System.Data.Entity;
using Tournaments.Models;

namespace Tournaments.Contracts
{
    public interface ITournamentsDbContext
    {
        DbSet<Team> Teams { get; set; }
        DbSet<Tournament> Tournaments { get; set; }
        DbSet<Player> Players { get; set; }
        int SaveChanges();

    }
}
