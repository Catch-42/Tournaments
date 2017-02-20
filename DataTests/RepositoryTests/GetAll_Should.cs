using Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournaments.Contracts;
using Tournaments.Models;

namespace DataTests.RepositoryTests
{
    [TestFixture]
    public class GetAll_Should
    {
        [Test]
        public void ReturnAList_WhenItIsCalled()
        {
            var tournamentsDbContextMock = new Mock<TournamentsDbContext>();  //INTERFACE
            var tounamentRepository = new TournamentsRepository<Team>(tournamentsDbContextMock.Object);
            tounamentRepository.All();

            tournamentsDbContextMock.Verify(x=>x.DbSet, Times.Once);


        }
        //return this.DbSet.ToList();

    }
}
