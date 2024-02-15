using AndreinaArtistica.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtPiecesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ArtPieces> Get()
        {
            return new List<ArtPieces>
            {
                new ArtPieces
                {
                    Id = 1,
                    Titulo = "Name 1"
                },
                new ArtPieces
                {
                    Id = 2,
                    Titulo = "Name 2"
                }
            };
        }
    }
}