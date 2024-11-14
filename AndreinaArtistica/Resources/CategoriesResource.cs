using AndreinaArtistica.Helpers.Abstract;
using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Resources
{
    public class CategoriesResource : ICategoriesResource
    {
        private readonly AndreinartisticaContext _context;
        private readonly IDatabaseHelper _databaseHelper;

        public CategoriesResource(AndreinartisticaContext context, IDatabaseHelper databaseHelper)
        {
            _context = context;
            _databaseHelper = databaseHelper;
        }
        public async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            var categoryList = await _databaseHelper.GetCategoriesFromDB();
            var viewModel = categoryList.Select(category => new CategoryViewModel
            {
                Id = category.Id,
                Name = category.Name
            });

            return viewModel;
        }
        private async Task<List<Category>> GetCategoriesFromDB()
        {
            var categoriesContext = _context.Categories
                .Select(category => new Category { Id = category.Id, Name = category.Name });
            return await categoriesContext.ToListAsync();
        }
    }
}