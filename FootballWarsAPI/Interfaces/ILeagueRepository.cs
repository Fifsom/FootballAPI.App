using FootballWarsAPI.Models;

namespace FootballWarsAPI.Interfaces
{
    public interface ILeagueRepository
    {
        Task<League> GetLeague();
        Task<IEnumerable<League>> GetAllLeagues();
        Task<League> GetLeagueById(int id);
        Task<League> AddLeague(League league);
        Task<League> UpdateLeague(League league);
        Task<League> DeleteLeague(int id);
    }
}
