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

namespace Tournaments
{
    [PresenterBinding(typeof(PlayerPresenter))]
    public partial class Players : MvpPage<PlayerViewModel>, IPlayerView
    {
        public event EventHandler MyInit;
        public event EventHandler<GenericEventArgs<Player>> SendPlayer;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyInit?.Invoke(sender, e);

            this.GridView2.DataSource = this.Model.Players;
            this.GridView2.DataBind();
        }


    }
}