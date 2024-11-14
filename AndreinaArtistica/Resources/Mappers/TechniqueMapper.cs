using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class TechniqueMapper
    {
        public static TechniqueViewModel MapToViewModel(this Technique technique, List<Technique> Technique)
        {
            var viewModel = new TechniqueViewModel
            {
                Id = technique.Id,
                Name = technique.Name
            };

            return viewModel;
        }
    }
}
