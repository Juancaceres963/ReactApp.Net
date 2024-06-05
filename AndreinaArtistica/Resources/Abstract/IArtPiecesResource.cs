using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface IArtPiecesResource
    {
        public Task<IEnumerable<ArtPieceViewModel>> GetArtPieces(int Ids, bool Availability, int Top, int Skip, DateTime Elaborated);
    }
}
