using FootballWarsAPI.Data;
using FootballWarsAPI.Interfaces;
using FootballWarsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballWarsAPI.Repositories
{
    public class FootballRepository : IFootballRepository
    {
        private readonly FootballContext _context;

        public FootballRepository(FootballContext context)
        {
            _context = context;
        }

        //Player
        public async Task<Player> AddPlayer(Player player)
        {
            var result = await _context.Player.AddAsync(player);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Player> DeletePlayer(int id)
        {
            var result = await _context.Player.FirstOrDefaultAsync(x => x.Id == id);
            if(result != null)
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
            var rand = new Random();
            var avialablePlayers = await _context.Player.ToListAsync();
            int index = rand.Next(avialablePlayers.Count);
            randomPlayer = avialablePlayers[index];

            return randomPlayer;
        }

        public async Task<Player> GetPlayerById(int id)
        {
            return await _context.Player.FirstOrDefaultAsync(x => x.Id == id);
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

        //League
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

        //Club

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
