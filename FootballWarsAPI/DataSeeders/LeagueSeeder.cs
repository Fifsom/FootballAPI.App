using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.DataSeeders
{
    public class LeagueSeeder
    {
        public static void SeedLeagues(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>().HasData(
                new League { Id = 1, Name = "Premier League", Img_Name = "PremierImg"},
                new League { Id = 2, Name = "Laliga", Img_Name = "LaligaImg" },
                new League { Id = 3, Name = "Serie A", Img_Name = "SerieAImg" },
                new League { Id = 4, Name = "Bundesliga", Img_Name = "BundesligaImg" },
                new League { Id = 5, Name = "Ligue 1", Img_Name = "Ligue1Img" }
                );
        }
    }
}
