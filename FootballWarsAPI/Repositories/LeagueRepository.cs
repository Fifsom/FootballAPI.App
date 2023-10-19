using FootballWarsAPI.Data;
using FootballWarsAPI.Interfaces;
using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        private readonly FootballContext _context;

        public LeagueRepository(FootballContext context)
        {
            _context = context;
        }

        public async Task<League> AddLeague(League league)
        {
            var result = await _context.League.AddAsync(league);
            _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<League> DeleteLeague(int id)
        {
            var result = await _context.League.FirstOrDefaultAsync(x => x.Id == id);

            if (result != null)
            {
                _context.League.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<League>> GetAllLeagues()
        {
            return await _context.League.ToListAsync();
        }

        public async Task<League> GetLeague()
        {
            League randomLeague = new();
            var rand = new Random();
            var availableLeagues = await _context.League.ToListAsync();
            int index = rand.Next(availableLeagues.Count);
            randomLeague = availableLeagues[index];

            return randomLeague;
        }

        public async Task<League> GetLeagueById(int id)
        {
            return await _context.League.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<League> UpdateLeague(League league)
        {
            var result = await _context.League.FirstOrDefaultAsync(x => x.Id == league.Id);

            if (result != null)
            {
                result.Name = league.Name;
                result.Img_Name = league.Img_Name;
                result.Clubs = league.Clubs;

                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
