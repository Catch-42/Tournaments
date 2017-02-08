using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Contracts;
using Tournaments.Models;

using Tournaments.Presenters;
using Tournaments.Services;

namespace Tournaments.App_Start
{
    public class TeamsNinjectModule : NinjectModule
    {
        public override void Load()
        {
            //this.Bind<IDbContext>().To<MyNorthwindDbContext>().InRequestScope();

            this.Bind<TeamPresenter>().ToSelf();
            this.Bind<TournamentPresenter>().ToSelf();
            this.Bind<PlayerPresenter>().ToSelf();
            this.Bind<ITournamentsDbContext>().To<TournamentsDbContext>(); 

            //this.Bind<EmpDetailsPresenter>().ToSelf();

            this.Bind<IDataProvider>().To<DataProvider>();
        }
    }
}