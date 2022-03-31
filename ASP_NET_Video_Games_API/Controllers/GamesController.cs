using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetGames()
        {
            var videoGame = _context.VideoGames.Select(p => p.Name).Distinct();
            return Ok(videoGame);
        }

        [HttpGet("{id}")]
        public IActionResult GetGamesById(int id)
        {
            var videoGamesById = _context.VideoGames.Where(p => p.Id == id);
            return Ok(videoGamesById);
        }
    }
}
