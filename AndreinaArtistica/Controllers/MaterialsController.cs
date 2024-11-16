using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaterialsController : ControllerBase
    {
        private readonly IMaterialsResource _materialsResource;

        public MaterialsController(IMaterialsResource materialsResource)
        {
            _materialsResource = materialsResource;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaterialViewModel>>> Get()
        {
            var result = await _materialsResource.GetMaterials();
            return Ok(result);
        }
    }
}