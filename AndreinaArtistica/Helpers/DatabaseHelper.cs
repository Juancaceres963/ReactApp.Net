using AndreinaArtistica.Helpers.Abstract;
using AndreinaArtistica.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Helpers
{
    public static class DatabaseHelper
    {

        public static async Task<List<Category>> GetCategoriesFromDB(AndreinartisticaContext context)
        {
            return await context.Categories.ToListAsync();
        }

        public static async Task<List<Material>> GetMaterialsFromDB(AndreinartisticaContext context)
        {
            return await context.Materials.ToListAsync();
        }

        public static async Task<List<Topic>> GetTopicsFromDB(AndreinartisticaContext context)
        {
            return await context.Topics.ToListAsync();
        }

        public static async Task<List<Technique>> GetTechniquesFromDB(AndreinartisticaContext context)
        {
            return await context.Techniques.ToListAsync();
        }
    }
}
