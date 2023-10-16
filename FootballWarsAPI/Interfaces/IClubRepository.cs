using FootballWarsAPI.Models;

namespace FootballWarsAPI.Interfaces
{
    public interface IClubRepository
    {
        Task<Club> GetClub();
        Task<IEnumerable<Club>> GetAllClubs();
        Task<Club> GetClubById(int id);
        Task<Club> AddClub(Club club);
        Task<Club> UpdateClub(Club club);
        Task<Club> DeleteClub(int id);
    }
}
