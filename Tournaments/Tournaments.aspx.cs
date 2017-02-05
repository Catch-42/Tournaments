using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tournaments.Models_project;
using Tournaments.Presenters;
using Tournaments.Views;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Tournaments
{
    [PresenterBinding(typeof(TournamentPresenter))]
    public partial class Tournaments : MvpPage<TournamentViewModel>, ITournamentView
    {
        public event EventHandler MyInit;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyInit?.Invoke(sender, e);

            this.GridView1.DataSource = this.Model.Tournaments;
            this.GridView1.DataBind();
        }
    }
}