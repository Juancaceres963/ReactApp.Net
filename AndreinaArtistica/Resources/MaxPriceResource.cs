using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;
using AndreinaArtistica.Resources.Abstract;
using Microsoft.EntityFrameworkCore;

namespace AndreinaArtistica.Resources
{
    public class MaxPriceResource : IMaxPriceResource
    {
        private readonly AndreinartisticaContext _context;

        public MaxPriceResource(AndreinartisticaContext context)
        {
            _context = context;
        }

        async Task<IEnumerable<MaxPriceViewModel>> IMaxPriceResource.GetMaxPrice()
        {
            // Obtener el precio máximo directamente desde la base de datos
            var maxPrice = await _context.ArtPieces
                .MaxAsync(artPiece => artPiece.Price);

            // Redondear hacia arriba el precio máximo
            var roundedMaxPrice = Math.Ceiling(maxPrice);

            // Crear el ViewModel con el precio redondeado
            var viewModel = new List<MaxPriceViewModel>
            {
                new MaxPriceViewModel { Price = (decimal)roundedMaxPrice }
            };

            return viewModel;
        }
    }
}