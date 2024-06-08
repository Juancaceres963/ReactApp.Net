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

            var viewModel = artPiecesList.Select(artPiece => artPiece.MapToViewModel(categoriesList, materialsList, topicsList));

            return viewModel;
        }

        private async Task<List<ArtPiece>> GetArtPiecesFromDB(ArtPieceQueryParameters parameters)
        {
            //var artPiecesContext = _context.ArtPieces
            //    .Where(x => x.Id == 1)
            //    .Where(x => x.Id == 1)
            //    .OrderBy(x => x.Elaborated)
            //    .Skip(0)
            //    .Take(100);

            var artPiecesContext = _context.ArtPieces.AsQueryable();

            if (!(parameters.Topic == null))
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Topic == (int)parameters.Topic);
            }

            if (parameters.Availability == true)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Availability == parameters.Availability);
            }

            if (parameters.MinPrice.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Price >= parameters.MinPrice.Value);
            }

            if (parameters.MaxPrice.HasValue)
            {
                artPiecesContext = artPiecesContext.Where(ap => ap.Price <= parameters.MaxPrice.Value);
            }

            //if (parameters.ids != null && parameters.ids.length > 0)
            //{
            //    artpiecescontext = artpiecescontext.where(ap => parameters.ids.contains(ap.id.tostring()));
            //}

            //if (parameters.sortby == "createddate")
            //{
            //    query = query.orderby(ap => ap.createddate);
            //}

            if (parameters.Skip > 0)
            {
                artPiecesContext = artPiecesContext.Skip(parameters.Skip);
            }

            if (parameters.Top > 0)
            {
                artPiecesContext = artPiecesContext.Take(parameters.Top);
            }

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
    }
}
