using Models.Contracts;
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
        private readonly ITournamentsRepository<ITeam> teamRepository;

        public TeamService(ITournamentsRepository<ITeam> teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public IEnumerable<ITeam> GetTeams()
        {
            return this.teamRepository.All();
        }

        public IEnumerable<ITeam> GetTeamById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return this.teamRepository.All().Where(t => t.Id == id).ToList(); // TODO TO LIST?

        }

        public IEnumerable<IPlayer> GetPlayers(int teamId)
        {
            if (teamId < 0)
            {
                throw new ArgumentException("Invalid teamId");
            }
            return this.teamRepository.GetById(teamId).Players;
        }


        public int UpdateTeam(ITeam team)
        {
            //var entry = this.tournamentsDbContext.Entry(team);
            //entry.State = EntityState.Modified;

            //return this.tournamentsDbContext.SaveChanges();

            if (team == null)
            {
                throw new ArgumentException("Team cannot be null.");
            }
            this.teamRepository.Update(team);
            return 1;
        }

        public int InsertTeam(ITeam team)
        {
            if (team == null)
            {
                throw new ArgumentException("Team cannot be null.");
            }

            this.teamRepository.Add(team);

            return 1;
        }

        public int DeleteTeam(int teamId)
        {
            if (teamId < 0)
            {
                throw new ArgumentException("Invalid teamId");
            }

            ITeam team = this.teamRepository.GetById(teamId);
            this.teamRepository.Delete(team);
            return 1;
        }

        public IEnumerable<ITeam> GetAllTeamsSortedById()
        {
            return this.teamRepository.All(); // TODO OrderBy<Team>(t=>t.Id);
        }


    }
}