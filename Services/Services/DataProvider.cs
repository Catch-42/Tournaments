using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Contracts;
using Tournaments.Models;

namespace Tournaments.Services
{
    public class DataProvider : IDataProvider
    {
        //private readonly IDbContext dbContext;
        private readonly ITournamentsDbContext tournamentsDbContext;

        //public DataProvider(IDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        public DataProvider(ITournamentsDbContext tournamentsDbContext)
        {
            this.tournamentsDbContext =tournamentsDbContext;
        }

        public IEnumerable<Team> GetTeams()
        {
            return this.tournamentsDbContext.Teams.ToList();
        }

        public IEnumerable<Team> GetTeamById(int id)
        {
            //return this.dbContext.Employees.Where(em => em.EmployeeID == id).ToList();
            return null;
        }

        public IEnumerable<Tournament> GetTournaments()
        {
            return this.tournamentsDbContext.Tournaments.ToList();
        }

        public IEnumerable<Tournament> GetTournamentById(int id)
        {
            return null;
        }

        public IEnumerable<Player> GetPlayers()
        {
            return this.tournamentsDbContext.Players.ToList();
        }

        public IEnumerable<Player> GetPlayerById(int id)
        {
            return null;
        }

        public void SavePlayer(Player player)
        {
            this.tournamentsDbContext.Players.Add(player);
            this.tournamentsDbContext.SaveChanges();


        }
    }
}