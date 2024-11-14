using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesResource _categoriesResource;

        public CategoriesController (ICategoriesResource CategoriesResource)
        {
            _categoriesResource = CategoriesResource;
        }
        [HttpGet]

        public async Task<ActionResult<IEnumerable<CategoryViewModel>>> Get()
        {
            var result = await _categoriesResource.GetCategories();
            return Ok(result);
        }
    }
}