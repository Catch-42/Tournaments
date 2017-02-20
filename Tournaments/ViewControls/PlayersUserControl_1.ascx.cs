using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tournaments.Models;
using Tournaments.Models_project;
using Tournaments.Presenters;
using Tournaments.Views;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Tournaments.ViewControls
{
    [PresenterBinding(typeof(PlayerPresenter))]
    public partial class PlayersUserControl_1 : MvpUserControl<PlayerViewModel>, IPlayerView
    {
        public event EventHandler MyInit;
        public event EventHandler OnGetData;
        public event EventHandler<GenericEventArgs<Player>> SendPlayer;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyInit?.Invoke(sender, e);

            this.GridViewPlayers.DataSource = this.Model.Players;
            this.GridViewPlayers.DataBind();
        }
    }
}