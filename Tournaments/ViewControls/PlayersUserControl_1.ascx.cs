﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
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
        public event EventHandler OnInsertItem;
        public event EventHandler<IdEventArgs> OnDeleteItem;
        public event EventHandler<IdEventArgs> OnUpdateItem;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyInit?.Invoke(sender, e);

            this.GridViewPlayers.DataSource = this.Model.Players;
            this.GridViewPlayers.DataBind();

            

            // this.EnableGridViewButtions();
        }

        private void EnableGridViewButtions()
        {
            //if the role is needed, just add ViewContext.HttpContext.User.IsInRole("Your role")
            bool isLoggedIn = (HttpContext.Current.User != null) &&
                HttpContext.Current.User.Identity.IsAuthenticated;

            if (isLoggedIn)
            {
                this.GridViewPlayers.AutoGenerateEditButton = true;
                this.GridViewPlayers.AutoGenerateDeleteButton = true;
            }
        }

        protected void OnGridViewPageChanged(object sender, GridViewPageEventArgs e)
        {
            this.GridViewPlayers.PageIndex = e.NewPageIndex;
            this.GridViewPlayers.DataSource = this.Model.Players;
            this.GridViewPlayers.DataBind();
        }
               

        public ModelStateDictionary ModelState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ModelStateDictionary IPlayerView.ModelState
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}