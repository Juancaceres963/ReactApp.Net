using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryViewModel MapToViewModel(this Category category, List<Category> Category)
        {
            var viewModel = new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            };
            return viewModel;
        }
    }
}
