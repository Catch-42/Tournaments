using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Services;
using Tournaments.Views;
using WebFormsMvp;

namespace Tournaments.Presenters
{
    public class TournamentPresenter : Presenter<ITournamentView>
    {
        private readonly IDataProvider provider;

        public TournamentPresenter(ITournamentView view, IDataProvider provider)
            : base(view)
        {
            this.provider = provider;
             this.View.MyInit += this.View_Init;
        }

        private void View_Init(object sender, EventArgs e)
        {
            this.View.Model.Tournaments = this.provider.GetTournaments();
        }
    }
}