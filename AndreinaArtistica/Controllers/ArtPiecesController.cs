using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtPiecesController : ControllerBase
    {
        private readonly IArtPiecesResource _artPiecesResource;

        public ArtPiecesController(IArtPiecesResource artPiecesResource)
        {
            _artPiecesResource = artPiecesResource;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArtPieceViewModel>>> Get() //Llamar al endpoint es llamar a este metodo (1er)
        {
            var result = await _artPiecesResource.GetArtPieces();

            return Ok(result);
        }
    }
}