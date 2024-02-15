using AndreinaArtistica.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtPiecesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ArtPiecesController> _logger;

        public ArtPiecesController(ILogger<ArtPiecesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ArtPieces> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new ArtPieces
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}