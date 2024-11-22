using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaxPriceController : ControllerBase
    {
        private readonly IMaxPriceResource _maxPriceResource;

        public MaxPriceController(IMaxPriceResource maxPriceResource)
        {
            _maxPriceResource = maxPriceResource;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MaxPriceViewModel>>> Get()
        {
            var result = await _maxPriceResource.GetMaxPrice();
            return Ok(result);
        }
    }
}