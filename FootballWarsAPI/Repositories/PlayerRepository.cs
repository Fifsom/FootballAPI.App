using FootballWarsAPI.Data;
using FootballWarsAPI.Interfaces;
using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FootballContext _context;

        public PlayerRepository(FootballContext context)
        {
            _context = context;
        }

        public Task<Player> AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public async Task<Player> DeletePlayer(int id)
        {
            var result = await _context.Player.FirstOrDefaultAsync(x => x.Id == id);
            if(result == null)
            {
                _context.Player.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            return await _context.Player.ToListAsync();
        }

        public async Task<Player> GetPlayer()
        {
            Player randomPlayer = new();
            var random = new Random();
            var avialablePlayers = await _context.Player.ToListAsync();
            int index = random.Next(avialablePlayers.Count);
            randomPlayer = avialablePlayers[index];

            return randomPlayer;
        }

        public Task<Player> GetPlayerById(int id)
        {
            return _context.Player.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Player> UpdatePlayer(Player player)
        {
            var result = await _context.Player.FirstOrDefaultAsync(x => x.Id == player.Id);

            if(result == null)
            {
                result.Name = player.Name;
                result.Club = player.Club;
                result.Img_Name = player.Img_Name;

                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
