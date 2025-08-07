using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Helpers.Abstract
{
    public interface IDatabaseHelper
    {
        public Task<List<Category>> GetCategoriesFromDB();

        public Task<List<Material>> GetMaterialsFromDB();

        public Task<List<Topic>> GetTopicsFromDB();

        public Task<List<Technique>> GetTechniquesFromDB();
    }
} 