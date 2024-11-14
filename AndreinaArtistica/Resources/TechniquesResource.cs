using AndreinaArtistica.Helpers.Abstract;
using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace AndreinaArtistica.Resources
{
    public class TechniquesResource : ITechniquesResource
    {
        private readonly AndreinartisticaContext _context;
        private readonly IDatabaseHelper _databaseHelper;

        public TechniquesResource(AndreinartisticaContext context, IDatabaseHelper databaseHelper)
        {
            _context = context;
            _databaseHelper = databaseHelper;
        }
        public async Task<IEnumerable<TechniqueViewModel>> GetTechniques()
        {
            var techniqueList = await _databaseHelper.GetTechniquesFromDB();

            var viewModel = techniqueList.Select(technique => new TechniqueViewModel
            {
                Id = technique.Id,
                Name = technique.Name
            });

            return viewModel;
        }
        private async Task<List<Technique>> GetTechniquesFromDB()
        {
            var techniquesContext = _context.Techniques
                .Select(technique => new Technique { Id = technique.Id, Name = technique.Name });
            return await techniquesContext.ToListAsync();
        }
    }
}
