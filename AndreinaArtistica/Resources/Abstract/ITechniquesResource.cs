using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface ITechniquesResource
    {
        public Task<IEnumerable<TechniqueViewModel>> GetTechniques();
    }
}
