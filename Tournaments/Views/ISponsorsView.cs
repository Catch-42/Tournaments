using System;
using Tournaments.Models_project;
using WebFormsMvp;

namespace Tournaments.Views
{
    public interface ISponsorsView : IView<SponsorsViewModel>
    {
        event EventHandler MyInit;
    }
}
