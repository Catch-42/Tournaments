using System;
using System.Collections.Generic;
using Tournaments.Models;

namespace Tournaments.Services
{
    public interface IDataProvider
    {
        IEnumerable<Team> GetTeams();

        IEnumerable<Team> GetTeamById(int id);

        IEnumerable<Tournament> GetTournaments();

        IEnumerable<Tournament> GetTournamentById(int id);

        IEnumerable<Player> GetPlayers();

        Player GetPlayerById(int id);

        void SavePlayer(Player player);
    }
}
