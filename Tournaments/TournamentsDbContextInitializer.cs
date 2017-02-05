using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tournaments.Models;

namespace Tournaments
{
    public class TournamentsDbContextInitializer: DropCreateDatabaseIfModelChanges<TournamentsDbContext>
    {
        protected override void Seed(TournamentsDbContext context)
        {
            var teams = new List<Team>
            {
                new Team { Name="Team1",Rating=1},
                new Team { Name="Team2",Rating=2}
            };

            var tournaments = new List<Tournament>
            {
                new Tournament { Name="Tournament1",Date=new DateTime(2016,2,1), Prize=1},
                new Tournament { Name="Tournament2",Date=new DateTime(2016,2,2), Prize=2},
          
            };

            tournaments.ForEach(tournament => context.Tournaments.Add(tournament));

        }
    }
 
}