using AndreinaArtistica.Controllers.Parameters;
using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using AndreinaArtistica.Resources.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

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

            // TODO: mover cada filtro (o grupo de filtros) a un método privado para mejorar la legibilidad

            // Filter by list of IDs
            if (parameters.Ids != null && parameters.Ids.Any())
            {
                artPiecesContext = artPiecesContext.Where(ap => parameters.Ids.Contains(ap.Id));
            }

            // Filter by Category
            if (parameters.Categories != null && parameters.Categories.Any())
            {
                artPiecesContext = artPiecesContext.Where(ap => parameters.Categories.Contains(ap.Category));
            }

            // Filter by Topic
            if (parameters.Topics != null && parameters.Topics.Any())
            {
                artPiecesContext = artPiecesContext.Where(ap => parameters.Topics.Contains(ap.Topic));
            }

            // Filter by Techniques
            if (parameters.Techniques != null && parameters.Techniques.Any())
            {
                artPiecesContext = artPiecesContext.Where(ap => parameters.Techniques.Contains(ap.Technique));
            }

            // Filter By Min Max Pices
            if (parameters.MinPrice.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == false || ap.Price >= parameters.MinPrice.Value);
            }

            if (parameters.MaxPrice.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == false || ap.Price <= parameters.MaxPrice.Value);
            }

            // Filter by Availability
            if (parameters.Availability.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == parameters.Availability);
            }

            // Sort by createdDate if specified
            if (!string.IsNullOrEmpty(parameters.OrderBy))
            {
                artPiecesContext = artPiecesContext.OrderBy(parameters.OrderBy);
            }

            artPiecesContext = artPiecesContext.Skip(parameters.Skip);
            artPiecesContext = artPiecesContext.Take(parameters.Top);

            return await artPiecesContext.ToListAsync();
        }

        // TODO: Quizás mover estos métodos a una clase de base de datos para reutilizarlos
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
