using AndreinaArtistica.Controllers.Parameters;
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
        public async Task<ActionResult<IEnumerable<ArtPieceViewModel>>> Get([FromQuery] ArtPieceQueryParameters parameters)
        {
            var result = await _artPiecesResource.GetArtPieces(parameters);
            return Ok(result);
        }
    }
}