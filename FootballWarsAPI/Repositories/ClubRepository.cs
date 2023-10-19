using FootballWarsAPI.Data;
using FootballWarsAPI.Interfaces;
using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace FootballWarsAPI.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly FootballContext _context;

        public ClubRepository(FootballContext context)
        {
            _context = context;
        }

        public async Task<Club> AddClub(Club club)
        {
            var result = await _context.Club.AddAsync(club);
            await _context.SaveChangesAsync();
            return null; //Not finished
        }

        public async Task<Club> DeleteClub(int id)
        {
            var result = await _context.Club.FirstOrDefaultAsync(x => x.Id == id);

            if (result != null)
            {
                _context.Club.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Club>> GetAllClubs()
        {
            return await _context.Club.ToListAsync();
        }

        public async Task<Club> GetClub()
        {
            Club randomClub = new();
            var rand = new Random();
            var availableClubs = await _context.Club.ToListAsync();
            int index = rand.Next(availableClubs.Count);
            randomClub = availableClubs[index];

            return randomClub;
        }

        public async Task<Club> GetClubById(int id)
        {
            return await _context.Club.FirstOrDefaultAsync(x => x.Id == id);
            
        }

        public async Task<Club> UpdateClub(Club club)
        {
            var result = await _context.Club.FirstOrDefaultAsync(x => x.Id == club.Id);

            if (result != null)
            {
                result.Name = club.Name;
                result.Img_Name = club.Img_Name;
                result.League = club.League;
                result.Players = club.Players;

                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
