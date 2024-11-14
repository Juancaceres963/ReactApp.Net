using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TechniquesController : ControllerBase
    {
        private readonly ITechniquesResource _techniquesResource;

        public TechniquesController(ITechniquesResource techniqueResource)
        {
            _techniquesResource = techniqueResource;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<TechniqueViewModel>>> Get()
        {
            var result = await _techniquesResource.GetTechniques();
            return Ok(result);
        }
    }
}
