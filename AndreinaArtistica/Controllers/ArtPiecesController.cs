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
        public async Task<ActionResult<IEnumerable<ArtPieceViewModel>>> Get([FromQuery] GetArtPiecesParameters parameters) //Llamar al endpoint es llamar a este metodo (1er)
        {
            var result = await _artPiecesResource.GetArtPieces(parameters.Ids, parameters.Availability, parameters.Top, parameters.Skip, parameters.Elaborated);
            
            return Ok(result);
        }
    }
}