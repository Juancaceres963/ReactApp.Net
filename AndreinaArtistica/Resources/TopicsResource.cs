using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace AndreinaArtistica.Resources
{
    public class TopicesResource : ITopicsResource
    {
        private readonly AndreinartisticaContext _context;

        public TopicesResource(AndreinartisticaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TopicViewModel>> GetTopics()
        {
            var topicsList = await GetTopicsFromDB();

            var viewModel = topicsList.Select(topic => new TopicViewModel
            {
                Id = topic.Id,
                Name = topic.Name
            });

            return viewModel;
        }
        private async Task<List<Topic>> GetTopicsFromDB()
        {
            var topicsContext = _context.Topics
                .Select(topic => new Topic { Id = topic.Id, Name = topic.Name});
            return await topicsContext.ToListAsync();
        }
    }
}
