using System;
using Tournaments.Models;
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
            this.View.SendPlayer += this.View_SendPlayer;
            //this.View.OnGetData += this.View_OnGetData();
        }

        private void View_Init(object sender, EventArgs e)
        {
            this.View.Model.Players = this.provider.GetPlayers();
        }

        private void View_SendPlayer(object sender, GenericEventArgs<Player> e)
        {
            this.provider.SavePlayer(e.EntityProp);
        }

        private void View_OnGetData(object sender, EventArgs e)
        {
            this.View.Model.Players = this.provider.GetPlayers();
        }
    }
}