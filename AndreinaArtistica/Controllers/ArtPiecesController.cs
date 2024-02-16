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
        public ActionResult<IEnumerable<ArtPieceViewModel>> Get()
        {
            var result = _artPiecesResource.GetArtPieces();

            return Ok(result);
        }
    }
}