using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class ArtPieceMapper
    {
        public static ArtPieceViewModel MapToViewModel(this ArtPiece artPiece)
        {
            var viewModel = new ArtPieceViewModel
            {
                Id = artPiece.Id,
                Title = artPiece.Title,
                Location = artPiece.Location
            };

            return viewModel;
        }
    }
}
