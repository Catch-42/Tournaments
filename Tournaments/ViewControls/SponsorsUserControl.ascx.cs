﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tournaments.Models_project;
using Tournaments.Presenters;
using Tournaments.Views;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace Tournaments.ViewControls
{
    [PresenterBinding(typeof(SponsorPresenter))]
    public partial class SponsorsUserControl : MvpUserControl<SponsorViewModel>, ISponsorView
    {
        public ModelStateDictionary ModelState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler MyInit;
        public event EventHandler<IdEventArgs> OnDeleteItem;
        public event EventHandler OnGetData;
        public event EventHandler OnInsertItem;
        public event EventHandler<IdEventArgs> OnUpdateItem;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MyInit?.Invoke(sender, e);

            this.GridViewSponsors.DataSource = this.Model.Sponsors;
            this.GridViewSponsors.DataBind();
        }
    }
}