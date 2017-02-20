using Models.Contracts;
using Moq;
using NUnit.Framework;
using Services.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Models_project;
using Tournaments.Presenters;
using Tournaments.Views;

namespace Tournaments.MVP.Tests.PresentersTests.TeamPresenterTests
{
    //[TestFixture]
    public class View_OnCategoriesGetData_Should
    {
        //[Test]
        public void CallGetAllTeamsSortedById_WhenOnGetDataEventIsRaised()
        {

        //    private void View_OnGetData(object sender, EventArgs e)
        //{
        //    this.View.Model.Teams = this.teamService.GetAllTeamsSortedById();
        //}

        // Arrange
        //var viewMock = new Mock<ITeamView>();
          //  viewMock.Setup(v => v.Model).Returns(new TeamViewModel());





        //    var teams = GetTeams();
        //    var teamServiceMock = new Mock<ITeamService>();
        //    teamServiceMock.Setup(c => c.GetAllTeamsSortedById())
        //        .Returns(teams);

        //    TeamPresenter teamPresenter = new TeamPresenter(viewMock.Object, teamServiceMock.Object);

        //    // Act
        //    viewMock.Raise(v => v.OnCategoriesGetData += null, EventArgs.Empty);

        //    // Assert
        //    CollectionAssert.AreEquivalent(categories, viewMock.Object.Model.Categories1);
        //}

        //private IQueryable<ITeam> GetTeams()
        //{
        //    return new List<ITeam>()
        //    {
        //        new Team()
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Category 1",
        //            Books = new List<Book>() { new Book() { Id = Guid.NewGuid() } }
        //        },
        //        new Category()
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Category 2"
        //        }
        //    }.AsQueryable();
        }
    }
}

