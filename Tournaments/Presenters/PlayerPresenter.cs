using Bytes2you.Validation;
using Services.Services.Contracts;
using System;
using Tournaments.Models;
using Tournaments.Services;
using Tournaments.Views;
using WebFormsMvp;

namespace Tournaments.Presenters
{
    public class PlayerPresenter : Presenter<IPlayerView>
    {
        private readonly IPlayerService playerService;

        public PlayerPresenter(IPlayerView view, IPlayerService playerService)
            : base(view)
        {
            Guard.WhenArgument(playerService, "PlayerService").IsNull().Throw();
            Guard.WhenArgument(view, "PlayerView").IsNull().Throw();

            this.playerService = playerService;
            this.View.MyInit += this.View_Init;
            this.View.SendPlayer += this.View_SendPlayer;
            //this.View.OnGetData += this.View_OnGetData();
        }

        private void View_Init(object sender, EventArgs e)
        {
            this.View.Model.Players = this.playerService.GetPlayers();
        }

        private void View_SendPlayer(object sender, GenericEventArgs<Player> e)
        {
            this.playerService.SavePlayer(e.EntityProp);
        }

        private void View_OnGetData(object sender, EventArgs e)
        {
            this.View.Model.Players = this.playerService.GetPlayers();
        }
    }
}