using AndreinaArtistica.Helpers.Abstract;
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
        private readonly IDatabaseHelper _databaseHelper;

        public TopicesResource(AndreinartisticaContext context, IDatabaseHelper databaseHelper)
        {
            _context = context;
            _databaseHelper = databaseHelper;
        }
        public async Task<IEnumerable<TopicViewModel>> GetTopics()
        {
            var topicsList = await _databaseHelper.GetTopicsFromDB();

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
