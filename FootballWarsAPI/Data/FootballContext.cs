using FootballWarsAPI.DataSeeders;
using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.Data
{
    public class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions<FootballContext> options)
            : base(options)
        {
        }

        public DbSet<Player>? Player { get; set; }
        public DbSet<Club>? Club { get; set; }
        public DbSet<League>? League { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(c => c.Club)
                .WithMany(p => p.Players)
                .HasForeignKey(c => c.ClubId);

            modelBuilder.Entity<Club>()
                .HasOne(l => l.League)
                .WithMany(c => c.Clubs)
                .HasForeignKey(l => l.LeagueId);

            LeagueSeeder.SeedLeagues(modelBuilder);
            ClubSeeder.SeedClubs(modelBuilder);
            PlayerSeeder.SeedPlayers(modelBuilder);
        }
    }
}
