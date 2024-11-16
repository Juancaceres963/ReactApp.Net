using AndreinaArtistica.Helpers.Abstract;
using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Resources
{
    public class MaterialsResource : IMaterialsResource
    {
        private readonly AndreinartisticaContext _context;
        private readonly IDatabaseHelper _databaseHelper;

        public MaterialsResource(AndreinartisticaContext context, IDatabaseHelper databaseHelper)
        {
            _context = context;
            _databaseHelper = databaseHelper;
        }

        public async Task<IEnumerable<MaterialViewModel>> GetMaterials()
        {
            var materialsList = await _databaseHelper.GetMaterialsFromDB();

            var viewModel = materialsList.Select( material => new MaterialViewModel { Id = material.Id, Name = material.Name, });

            return viewModel;
        }

        private async Task<List<Material>> GetMaterialsFromDB()
        {
            var materialsContext = _context.Materials
                .Select(material => new Material { Id = material.Id, Name = material.Name });
            return await materialsContext.ToListAsync();
        }
    }
}
