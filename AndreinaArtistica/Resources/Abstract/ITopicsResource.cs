using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface ITopicsResource
    {
        public Task<IEnumerable<TopicViewModel>> GetTopics();
    }
}