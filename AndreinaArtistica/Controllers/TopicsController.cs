using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AndreinaArtistica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicsResource _topicsResource;

        public TopicsController(ITopicsResource topicsResource)
        {
            _topicsResource = topicsResource;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicViewModel>>> Get()
        {
            var result = await _topicsResource.GetTopics();
            return Ok(result);
        }
    }
}