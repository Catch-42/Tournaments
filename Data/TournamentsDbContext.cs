using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tournaments.Contracts;
using Tournaments.Migrations;

namespace Tournaments.Models
{
    public class TournamentsDbContext: IdentityDbContext<Player>, ITournamentsDbContext
    {
        public TournamentsDbContext()
            : base("TournamentsDb2")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TournamentsDbContext, Configuration>());
        }

        public DbSet<Team> Teams { get; set; }
        //public DbSet<Player> Players { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Game> Games;
        public DbSet<Sponsor> Sponsors;
        public DbSet<SponsorsTournaments> SponsorsTournamentsTable;

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public static TournamentsDbContext Create()
        {
            return new TournamentsDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}