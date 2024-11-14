using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface ICategoriesResource
    {
        public Task<IEnumerable<CategoryViewModel>> GetCategories();
    }
}