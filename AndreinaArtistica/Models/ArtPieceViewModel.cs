namespace AndreinaArtistica.Models
{
    public class ArtPieceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public DateTime Elaborated { get; set; }
        public string Topic { get; set; }
        public string Technique { get; set; }

        //public string? SubTopic { get; set; }
        public string? Location { get; set; }
        public bool Availability { get; set; }
        public decimal Price { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        //public static implicit operator ArtPieceViewModel(ArtPieceViewModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}