using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using AndreinaArtistica.Resources.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

            //Tabla de ArtPieces
            var artPiecesContext = _context.ArtPieces;
            var artPiecesList = await artPiecesContext.ToListAsync();

            //Tabla de Categories
            var categoriesContext = _context.Categories;
            var categoriesList = await categoriesContext.ToListAsync();

            //Tabla de Material
            var materialsContext = _context.Materials;
            var materialsList = await materialsContext.ToListAsync();

            //Tabla de Topic
            var TopicsContext = _context.Topics;
            var TopicsList = await TopicsContext.ToListAsync();

            // 2 Mappear Artpiece a ArtPieceViewModel y devolverlo

            var viewModel = artPiecesList.Select(artPiece => artPiece.MapToViewModel(categoriesList, materialsList, TopicsList));

            return viewModel;
        }
    }
}
