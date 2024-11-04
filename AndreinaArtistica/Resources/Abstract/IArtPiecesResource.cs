using AndreinaArtistica.Controllers.Parameters;
using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface IArtPiecesResource
    {
        public Task<IEnumerable<ArtPieceViewModel>> GetArtPieces(ArtPieceQueryParameters parameters);
    }
}
