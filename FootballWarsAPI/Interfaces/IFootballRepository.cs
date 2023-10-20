using FootballWarsAPI.Models;

namespace FootballWarsAPI.Interfaces
{
    public interface IFootballRepository
    {
        //player
        Task<Player> GetPlayer();
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(int id);
        Task<Player> AddPlayer(Player player);
        Task<Player> UpdatePlayer(Player player);
        Task<Player> DeletePlayer(int id);

        //League
        Task<League> GetLeague();
        Task<IEnumerable<League>> GetAllLeagues();
        Task<League> GetLeagueById(int id);
        Task<League> AddLeague(League league);
        Task<League> UpdateLeague(League league);
        Task<League> DeleteLeague(int id);

        //Club
        Task<Club> GetClub();
        Task<IEnumerable<Club>> GetAllClubs();
        Task<Club> GetClubById(int id);
        Task<Club> AddClub(Club club);
        Task<Club> UpdateClub(Club club);
        Task<Club> DeleteClub(int id);
    }
}
