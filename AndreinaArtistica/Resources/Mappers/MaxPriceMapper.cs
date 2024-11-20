using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class MaxPriceMapper
    {
        public static MaxPriceViewModel MapToViewModel(this ArtPiece artPiece, List<MaxPrice> MaxPrice)
        {
            var viewModel = new MaxPriceViewModel
            {
                Price = artPiece.Price
            };

            return viewModel;
        }
    }
}