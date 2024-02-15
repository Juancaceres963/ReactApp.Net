using AndreinaArtistica.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtPiecesController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ArtPiece> Get()
        {
            return new List<ArtPiece>
            {
                new ArtPiece
                {
                    Id = 1,
                    Titulo = "Name 1"
                },
                new ArtPiece
                {
                    Id = 2,
                    Titulo = "Name 2"
                }
            };
        }
    }
}