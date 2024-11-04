using AndreinaArtistica.Models;
using AndreinaArtistica.Models.DB;

namespace AndreinaArtistica.Resources.Mappers
{
    public static class ArtPieceMapper
    {
        public static ArtPieceViewModel MapToViewModel(this ArtPiece artPiece, List<Category> categories, List<Material> materials, List<Topic> Topics, List<Technique> Techniques)
        {
            var viewModel = new ArtPieceViewModel
            {
                Id = artPiece.Id,
                Title = artPiece.Title,
                Location = artPiece.Location,
                Price = artPiece.Price,
                Availability = (bool)artPiece.Availability,
                Height = artPiece.Height,
                Width = artPiece.Width,
                Material = materials.FirstOrDefault(material => material.Id == artPiece.Material)?.Name,
                Category = categories.FirstOrDefault(category => category.Id == artPiece.Category)?.Name,
                Topic = Topics.FirstOrDefault(Topic => Topic.Id == artPiece.Topic)?.Name,
                Technique = Techniques.FirstOrDefault(Technique => Technique.Id == artPiece.Technique)?.Name,
            };
          
            return viewModel; 
        }
    }
}
