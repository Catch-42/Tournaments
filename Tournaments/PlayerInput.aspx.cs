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
    public partial class PlayerInput : MvpPage<PlayerViewModel>, IPlayerView
    {
        public event EventHandler MyInit;
        public event EventHandler<GenericEventArgs<Player>> SendPlayer;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSendPlayer_Click(object sender, EventArgs e)
        {

            Player pl = new Player() { FirstName = TextBoxFirstName.Text, LastName = TextBoxLastName.Text, NickName = "NickName1", Picture = "picture1", Email = "email1", Rating = 1, TeamId = 1, IsCoach = false, CV = "cv_________1" };
            //var p = new PlayerArgs(pl);
            var p = new GenericEventArgs<Player>(pl);

            this.SendPlayer?.Invoke(null, p);


        }
    }
}