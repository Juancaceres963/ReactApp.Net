using AndreinaArtistica.Controllers.Parameters;
using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using AndreinaArtistica.Resources.Mappers;
using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Resources
{
    public class ArtPiecesResource : IArtPiecesResource
    {
        private readonly AndreinartisticaContext _context;

        public ArtPiecesResource(AndreinartisticaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ArtPieceViewModel>> GetArtPieces(ArtPieceQueryParameters parameters)
        {
            // 1 Hacer un query que me devuelva todos los items de la base de datos

            var artPiecesList = await GetArtPiecesFromDB(parameters);
            var categoriesList = await GetCategoriesFromDB();
            var materialsList = await GetMaterialsFromDB();
            var topicsList = await GetTopicsFromDB();
            var techniquesList = await GetTechniquesFromDB();

            var viewModel = artPiecesList.Select(artPiece => artPiece.MapToViewModel(categoriesList, materialsList, topicsList, techniquesList));

            return viewModel;
        }

        private async Task<List<ArtPiece>> GetArtPiecesFromDB(ArtPieceQueryParameters parameters)
        {
            var artPiecesContext = _context.ArtPieces.AsQueryable();

            // Filter by Topic
            if (parameters.Topic.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Topic == (int)parameters.Topic);
            }

            // Filter by Availability
            if (parameters.Availability.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == parameters.Availability);
            }

            // Filter by Price Range if available
            if (parameters.Availability == true)
            {
                if (parameters.MinPrice.HasValue)
                {
                    artPiecesContext = artPiecesContext.Where(ap => ap.Price >= parameters.MinPrice.Value);
                }
                if (parameters.MaxPrice.HasValue)
                {
                    artPiecesContext = artPiecesContext.Where(ap => ap.Price <= parameters.MaxPrice.Value);
                }
            }

            // Filter by list of IDs
            if (parameters.Ids != null && parameters.Ids.Any())
            {
                artPiecesContext = artPiecesContext.Where(ap => parameters.Ids.Contains(ap.Id));
            }

            // Sort by createdDate if specified
            if (string.IsNullOrEmpty(parameters.SortBy))
            {
                artPiecesContext = artPiecesContext.OrderBy(ap => ap.Elaborated);
            }

            artPiecesContext = artPiecesContext.Skip(parameters.Skip);
            artPiecesContext = artPiecesContext.Take(parameters.Top);

            return await artPiecesContext.ToListAsync();
        }


        private async Task<List<Category>> GetCategoriesFromDB()
        {
            var categoriesContext = _context.Categories;
            return await categoriesContext.ToListAsync();
        }

        private async Task<List<Material>> GetMaterialsFromDB()
        {
            var materialsContext = _context.Materials;
            return await materialsContext.ToListAsync();
        }

        private async Task<List<Topic>> GetTopicsFromDB()
        {
            var topicsContext = _context.Topics;
            return await topicsContext.ToListAsync();
        }

        private async Task<List<Technique>> GetTechniquesFromDB()
        {
            var techniquesContext = _context.Techniques;
            return await techniquesContext.ToListAsync();
        }
    }
}
