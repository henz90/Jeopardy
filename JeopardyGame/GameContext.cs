using System.Data.Entity;

namespace JeopardyGame
{
    class GameContext : DbContext
    {

        public GameContext() : base("GameDb")
        {
            //Database.SetInitializer<GameContext>(new CreateDatabaseIfNotExists<GameContext>());
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<GameContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Game.Jeopardy> Jeopardy {get; set; }
        public DbSet<Game.DoubleJeopardy> DoubleJeopardy { get; set; }
        public DbSet<Game.FinalJeopardy> FinalJeopardy { get; set; }


    }
}
