using Services.Services;
using Services.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tournaments.Contracts;
using Tournaments.Models;

namespace Tournaments.Services
{
    public class TeamService : ITeamService
    {        
        private readonly ITournamentsRepository<Team> teamRepository;

        public TeamService(ITournamentsRepository<Team> teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public IEnumerable<Team> GetTeams()
        {
            return this.teamRepository.All();
        }

        public IEnumerable<Team> GetTeamById(int id)
        {
            return this.teamRepository.All().Where(t => t.Id == id).ToList(); // TODO TO LIST?

        }

       
        public IEnumerable<Player> GetPlayers(int teamId)
        {
            return this.teamRepository.GetById(teamId).Players;
        }

        
        

        public int UpdateTeam(Team team)
        {
            //var entry = this.tournamentsDbContext.Entry(team);
            //entry.State = EntityState.Modified;

            //return this.tournamentsDbContext.SaveChanges();

            this.teamRepository.Update(team);
            return 1;
            
        }

        public int InsertTeam(Team team)
        {
            this.teamRepository.Add(team);

            return 1;
        }

        public int DeleteTeam(int teamId)
        {
            Team team = this.teamRepository.GetById(teamId);
            this.teamRepository.Delete(team);
            return 1;
        }

        public IEnumerable<Team> GetAllTeamsSortedById()
        {
            return this.teamRepository.All(); //OrderBy<Team>(t=>t.Id);
            
        }
    }
}