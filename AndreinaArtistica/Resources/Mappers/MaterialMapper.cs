using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class MaterialMapper
    {
        public static MaterialViewModel MapToViewModel(this Material material, List<Material> Material)
        {
            var viewModel = new MaterialViewModel
            {
                Id = material.Id,
                Name = material.Name
            };

            return viewModel;
        }
    }
}