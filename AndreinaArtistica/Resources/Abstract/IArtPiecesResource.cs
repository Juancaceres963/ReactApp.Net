using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface IArtPiecesResource
    {
        public IEnumerable<ArtPieceViewModel> GetArtPieces();
    }
}
