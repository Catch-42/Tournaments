using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tournaments.Services;
using Tournaments.Views;
using WebFormsMvp;

namespace Tournaments.Presenters
{
    public class SponsorPresenter : Presenter<ISponsorsView>
    {
        private readonly IDataProvider provider;

        public SponsorPresenter(ISponsorsView view, IDataProvider provider)
            : base(view)
        {
            this.provider = provider;
            this.View.MyInit += this.View_Init;
        }

        private void View_Init(object sender, EventArgs e)
        {
            this.View.Model.Sponsors = this.provider.GetSponsors();
        }
    }
}