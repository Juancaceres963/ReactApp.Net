using AndreinaArtistica.Controllers.Parameters;
using AndreinaArtistica.Helpers.Abstract;
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
        private readonly IDatabaseHelper _databaseHelper;

        public ArtPiecesResource(AndreinartisticaContext context, IDatabaseHelper databaseHelper)
        {
            _context = context;
            _databaseHelper = databaseHelper;
        }

        public async Task<IEnumerable<ArtPieceViewModel>> GetArtPieces(ArtPieceQueryParameters parameters)
        {
            var artPiecesList = await GetArtPiecesFromDB(parameters);
            var categoriesList = await _databaseHelper.GetCategoriesFromDB();
            var materialsList = await _databaseHelper.GetMaterialsFromDB();
            var topicsList = await _databaseHelper.GetTopicsFromDB();
            var techniquesList = await _databaseHelper.GetTechniquesFromDB();

            var viewModel = artPiecesList.Select(artPiece => artPiece.MapToViewModel(categoriesList, materialsList, topicsList, techniquesList));

            return viewModel;
        }

        private async Task<List<ArtPiece>> GetArtPiecesFromDB(ArtPieceQueryParameters parameters)
        {
            var artPiecesContext = _context.ArtPieces.AsQueryable();

            artPiecesContext = ApplyFilters(artPiecesContext, parameters);
            artPiecesContext = ApplySortingAndPagination(artPiecesContext, parameters);

            return await artPiecesContext.ToListAsync();
        }

        private IQueryable<ArtPiece> ApplyFilters(IQueryable<ArtPiece> artPiecesContext, ArtPieceQueryParameters parameters)
        {
            if (parameters.Ids != null && parameters.Ids.Any())
                artPiecesContext = artPiecesContext.Where(ap => parameters.Ids.Contains(ap.Id));

            if (parameters.Categories != null && parameters.Categories.Any())
                artPiecesContext = artPiecesContext.Where(ap => parameters.Categories.Contains(ap.Category));

            if (parameters.Topics != null && parameters.Topics.Any())
                artPiecesContext = artPiecesContext.Where(ap => parameters.Topics.Contains(ap.Topic));

            if (parameters.Techniques != null && parameters.Techniques.Any())
                artPiecesContext = artPiecesContext.Where(ap => parameters.Techniques.Contains(ap.Technique));

            if (parameters.MinPrice.HasValue)
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == false || ap.Price >= parameters.MinPrice.Value);

            if (parameters.MaxPrice.HasValue)
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == false || ap.Price <= parameters.MaxPrice.Value);

            if (parameters.Availability.HasValue)
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == parameters.Availability);

            return artPiecesContext;
        }

        private IQueryable<ArtPiece> ApplySortingAndPagination(IQueryable<ArtPiece> artPiecesContext, ArtPieceQueryParameters parameters)
        {
            if (!string.IsNullOrEmpty(parameters.OrderBy))
                artPiecesContext = artPiecesContext.OrderBy(parameters.OrderBy);

            return artPiecesContext
                .Skip(parameters.Skip)
                .Take(parameters.Top);
        }
    }
}
