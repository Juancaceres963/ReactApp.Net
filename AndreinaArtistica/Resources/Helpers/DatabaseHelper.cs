using AndreinaArtistica.Models.DB;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndreinaArtistica.Resources.Helpers
{
    public class DatabaseHelper
    {
        private readonly AndreinartisticaContext _context;

        public DatabaseHelper(AndreinartisticaContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategoriesFromDB()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Material>> GetMaterialsFromDB()
        {
            return await _context.Materials.ToListAsync();
        }

        public async Task<List<Topic>> GetTopicsFromDB()
        {
            return await _context.Topics.ToListAsync();
        }

        public async Task<List<Technique>> GetTechniquesFromDB()
        {
            return await _context.Techniques.ToListAsync();
        }
    }
}
