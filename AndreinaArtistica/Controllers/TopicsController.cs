using AndreinaArtistica.Controllers.Parameters;
using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicsResource _TopicsResource;

        public TopicsController(ITopicsResource topicsResource)
        {
            _TopicsResource = topicsResource;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicViewModel>>> Get()
        {
            var result = await _TopicsResource.GetTopics();
            return Ok(result);
        }
    }
}