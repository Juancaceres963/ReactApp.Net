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
            //var beers = _context.Beers.Include(m => m.Brand);
            var artPieces = _context.ArtPieces;
            var result = await artPieces.ToListAsync();

            // 2 Mappear Artpiece a ArtPieceViewModel y devolverlo

            var viewModel = result.Select(x => x.MapToViewModel());

            return viewModel;
        }
    }
}
