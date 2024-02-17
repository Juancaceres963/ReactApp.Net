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
        public async Task<IEnumerable<ArtPieceViewModel>> GetArtPieces()
        {
            // 1 Hacer un query que me devuelva todos los items de la base de datos

            var artPiecesList = await GetArtPiecesFromDB();
            var categoriesList = await GetCategoriesFromDB();
            var materialsList = await GetMaterialsFromDB();
            var topicsList = await GetTopicsFromDB();

            var viewModel = artPiecesList.Select(artPiece => artPiece.MapToViewModel(categoriesList, materialsList, topicsList));

            return viewModel;
        }

        private async Task<List<ArtPiece>> GetArtPiecesFromDB()
        {
            var artPiecesContext = _context.ArtPieces;
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
