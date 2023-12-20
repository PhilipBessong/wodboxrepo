using Microsoft.EntityFrameworkCore;

namespace wodapi.Models
{
    public class AppDbContext  :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
        {
        }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<User> Users { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      


       
      

            modelBuilder.Entity<Style>().HasData(
                new Style { styleId = 1, styleName = "EMOM (Every Minute On the Minute)", styleDescription = "Perform a specific movement for a duration of one minute, transition immediately to the next movement at the start of the following minute. Continue for x number of minutes." },
                new Style { styleId = 2, styleName = "TABATA", styleDescription = "It consists of performing an exercise at maximum effort for 20 seconds, followed by a 10-second rest, and repeating this cycle for a total of eight rounds." },
                new Style { styleId = 3, styleName = "LADDER", styleDescription= "Start with a set number of repetitions for an exercise and increase it with each round until you reach a designated endpoint." },
                new Style { styleId = 4, styleName = "INTERVAL", styleDescription = "Alternates high-intensity exercise with rest (X number of rounds, Y amount of sec work and Z amount of rest)" },
                new Style { styleId = 5, styleName = "FGB (Fight gone bad)", styleDescription= "17-minute HIIT WOD 5 x exercises. Rotate stations, maximum reps per station. (3 rounds 5 min work. You have 1 minute rest after the first and second 5 min of work) total time 17 min" },
                new Style { styleId = 6, styleName = "AMRAP (as many rounds as possible)", styleDescription = "As many rounds of specific movements as possible in X amount of time." }
                );
        }
    }
}
