using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.DataSeeders
{
    public class ClubSeeder
    {
        public static void SeedClubs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(
                new Club { Id = 1, Name = "FC Barcelona", Img_Name = "FCBarcelonaImg", LeagueId = 2},
                new Club { Id = 2, Name = "Real Madrid", Img_Name = "RealMadridImg", LeagueId = 2 },
                new Club { Id = 3, Name = "Manchester City", Img_Name = "ManchesterCityImg", LeagueId = 1 },
                new Club { Id = 4, Name = "Arsenal FC", Img_Name = "ArsenalImg", LeagueId = 1 },
                new Club { Id = 5, Name = "Inter Milan", Img_Name = "InterImg", LeagueId = 3 },
                new Club { Id = 6, Name = "AC Milan", Img_Name = "ACMilanImg", LeagueId = 3 },
                new Club { Id = 7, Name = "FC Bayern Munchen", Img_Name = "FCBayernImg", LeagueId = 4 },
                new Club { Id = 8, Name = "Dortmund", Img_Name = "DortmundImg", LeagueId = 4 },
                new Club { Id = 9, Name = "Paris", Img_Name = "ParisImg", LeagueId = 5}
                );
        }
    }
}
