using FootballWarsAPI.Interfaces;
using FootballWarsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballWarsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballController : ControllerBase
    {
        private readonly IFootballRepository _footballRepository;

        public FootballController(IFootballRepository footballRepository)
        {
            _footballRepository = footballRepository;
        }

        [HttpGet("leagues")]
        public async Task<IEnumerable<League>> GetLeagues()
        {
            try
            {
                return await _footballRepository.GetAllLeagues();
            }
            catch
            {
                throw new Exception ("No leagues found.");
            }
        }
        [HttpGet("randomLeague")]
        public async Task<League> GetLeague()
        {
            try
            {
                return await _footballRepository.GetLeague();
            }
            catch
            {

                throw new Exception("Error while retrieving leagues.");
            }
        }

        [HttpGet("league{id}")]
        public async Task<League> GetLeagueById(int id)
        {
            try
            {
                return await _footballRepository.GetLeagueById(id);
            }
            catch
            {

                throw new Exception($"Error while retrieving league with id {id}.");
            }
        }

        [HttpPost("addLeague")]
        public async Task<League> AddLeague(League league)
        {
            try
            {
                return await _footballRepository.AddLeague(league);
            }
            catch (Exception)
            {

                throw new Exception("Error when adding a league.");
            }
        }

        [HttpPut("updateLeague")]
        public async Task<League> UpdateLeague(League league)
        {
            try
            {
                return await _footballRepository.UpdateLeague(league);
            }
            catch
            {

                throw new Exception("Error while updating league.");
            }
        }

        [HttpDelete("deleteLeague")]
        public async Task<League> DeleteLeague(int id)
        {
            try
            {
                return await _footballRepository.DeleteLeague(id);
            }
            catch
            {

                throw new Exception("Error while deleting league.");
            }
        }
    }
}
