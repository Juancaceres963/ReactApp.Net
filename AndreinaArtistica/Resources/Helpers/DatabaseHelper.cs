using AndreinaArtistica.Models.DB;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndreinaArtistica.Resources.Helpers
{
    public static class DatabaseHelper
    {
        private readonly AndreinartisticaContext _context;

        public static DatabaseHelper(AndreinartisticaContext context)
        {
            _context = context;
        }

        public static async Task<List<Category>> GetCategoriesFromDB()
        {
            return await _context.Categories.ToListAsync();
        }

        public static async Task<List<Material>> GetMaterialsFromDB()
        {
            return await _context.Materials.ToListAsync();
        }

        public static async Task<List<Topic>> GetTopicsFromDB()
        {
            return await _context.Topics.ToListAsync();
        }

        public static async Task<List<Technique>> GetTechniquesFromDB()
        {
            return await _context.Techniques.ToListAsync();
        }
    }
}
