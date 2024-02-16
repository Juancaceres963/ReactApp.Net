using AndreinaArtistica.Models;
using AndreinaArtistica.Resources.Abstract;

namespace AndreinaArtistica.Resources
{
    public class ArtPiecesResource : IArtPiecesResource
    {
        public IEnumerable<ArtPieceViewModel> GetArtPieces()
        {
            // 1 Hacer un query que me devuelva todos los items de la base de datos

            // 2 Mappear Artpiece a ArtPieceViewModel y devolverlo

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
