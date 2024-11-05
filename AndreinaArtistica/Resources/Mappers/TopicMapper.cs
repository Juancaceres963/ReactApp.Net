using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class TopicMapper
    {
        public static TopicViewModel MapToViewModel(this Topic topic)
        {
            var viewModel = new TopicViewModel
            {
                Id = topic.Id,
                Name = topic.Name
            };

            return viewModel;
        }
    } 
}
