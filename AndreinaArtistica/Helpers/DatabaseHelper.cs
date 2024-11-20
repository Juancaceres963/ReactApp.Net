using AndreinaArtistica.Helpers.Abstract;
using AndreinaArtistica.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Helpers
{
    public class DatabaseHelper : IDatabaseHelper
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

        //public Task<List<MaxPrice>> GetMaxPriceFromDB()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
