using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.DataSeeders
{
    public class PlayerSeeder
    {
        public static void SeedPlayers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, Name = "Frenkie De Jong", Img_Name = "FrenkieImg", ClubId = 1},
                new Player { Id = 2, Name = "Luka Modric", Img_Name = "LukaImg", ClubId = 2},
                new Player { Id = 3, Name = "Erling Haaland", Img_Name = "ErlingImg", ClubId = 3},
                new Player { Id = 4, Name = "Martin Odergaard", Img_Name = "MartinImg", ClubId =  4},
                new Player { Id = 5, Name = "Lautaro Martinez", Img_Name = "LautaroImg", ClubId = 5 },
                new Player { Id = 6, Name = "Rafael Leao", Img_Name = "RafaelImg", ClubId = 6 },
                new Player { Id = 7, Name = "Thomas Muller", Img_Name = "ThomasImg", ClubId = 7 },
                new Player { Id = 8, Name = "Marco Reus", Img_Name = "MarcoImg", ClubId = 8 },
                new Player { Id = 9, Name = "Kylian Mbappe", Img_Name = "KylianImg", ClubId = 9 }
                );
        }
    }
}
