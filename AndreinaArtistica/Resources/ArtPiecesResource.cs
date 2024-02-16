using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;

namespace AndreinaArtistica.Resources
{
    public class ArtPiecesResource : IArtPiecesResource
    {
        public IEnumerable<ArtPieceViewModel> GetArtPieces()
        {
            var viewModel = new List<ArtPieceViewModel>
            {
                new ArtPieceViewModel
                {
                    Id = 1,
                    Titulo = "Name 1"
                },
                new ArtPieceViewModel
                {
                    Id = 2,
                    Titulo = "Name 2"
                }
            };

            return viewModel;
        }
    }
}
