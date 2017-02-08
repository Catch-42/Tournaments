using System;
using Tournaments.Services;
using Tournaments.Views;
using WebFormsMvp;

namespace Tournaments.Presenters
{
    public class PlayerPresenter : Presenter<IPlayerView>
    {
        private readonly IDataProvider provider;

        public PlayerPresenter(IPlayerView view, IDataProvider provider)
            : base(view)
        {
            this.provider = provider;
            this.View.MyInit += this.View_Init;
        }

        private void View_Init(object sender, EventArgs e)
        {
            this.View.Model.Players = this.provider.GetPlayers();
        }
    }
}