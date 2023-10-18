using FootballWarsAPI.Models;

namespace FootballWarsAPI.Interfaces
{
    public interface IPlayerRepository
    {
        Task<Player> GetPlayer();
        Task<IEnumerable<Player>> GetAllPlayers();
        Task<Player> GetPlayerById(int id);
        Task<Player> AddPlayer(Player player);
        Task<Player> UpdatePlayer(Player player);
        Task<Player> DeletePlayer(int id);

    }
}
