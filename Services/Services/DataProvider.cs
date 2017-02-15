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
        private readonly ITournamentsRepository<Player> playerRepository;

        //public DataProvider(IDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //}

        public DataProvider(ITournamentsDbContext tournamentsDbContext, ITournamentsRepository<Player> playerRepository)
        {
            this.tournamentsDbContext =tournamentsDbContext;
            this.playerRepository = playerRepository;
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
            return this.playerRepository.All();
            //return this.tournamentsDbContext.Players.ToList();
        }

        public Player GetPlayerById(int id)
        {
            return this.playerRepository.GetById(id);
        }

        public void SavePlayer(Player player)
        {
            this.tournamentsDbContext.Players.Add(player);// TODO REPOSITORY
            this.tournamentsDbContext.SaveChanges();
        }

        public IEnumerable<Sponsor> GetSponsors()
        {
            // TODO: get the sponsors through a repository
            return this.tournamentsDbContext.Sponsors.ToList();
        }

        public Sponsor GetSponsorById(int id)
        {
            return null;
        }
    }
}