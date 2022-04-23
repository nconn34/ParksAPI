using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
    public class ParkApiContext : DbContext
    {
        public ParkApiContext(DbContextOptions<ParkApiContext> options)
            : base(options)
        {
        }

        //The string for Name won't allow for multiple words, but I am unsure how to fix that and allow it to take multiple words separated by spaces
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                    .HasData(
                        new Park { ParkId = 1, Name = "Rockymountain", Type = "NP", Location = "Colorado", YearFounded = 1924, Activities = "Hiking" },
                        new Park { ParkId = 2, Name = "Mt.rainier", Type = "NP", Location = "Washington", YearFounded = 1915, Activities = "Hiking" },
                        new Park { ParkId = 3, Name = "Capedisappointment", Type = "SP", Location = "Washington", YearFounded = 1936, Activities = "Surfing" },
                        new Park { ParkId = 4, Name = "Mtbaker", Type = "SP", Location = "Washington", YearFounded = 1946, Activities = "Snowboarding" },
                        new Park { ParkId = 5, Name = "Wyalusing", Type = "SP", Location = "Wisconsin", YearFounded = 1926, Activities = "Kayaking" }
                        );
        }


        public DbSet<Park> Parks { get; set; }
    }
}