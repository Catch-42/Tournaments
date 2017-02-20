using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Models;

namespace Services.Services.Contracts
{
    public interface ITeamService
    {
        IEnumerable<ITeam> GetTeams();

        IEnumerable<ITeam> GetTeamById(int id);


        IEnumerable<IPlayer> GetPlayers(int teamId);

        int UpdateTeam(ITeam team);

        int InsertTeam(ITeam team);


        int DeleteTeam(int teamId);

        IEnumerable<ITeam> GetAllTeamsSortedById();
       
    }
}
