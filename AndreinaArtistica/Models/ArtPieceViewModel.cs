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

        //public string? SubTopic { get; set; }
        public string? Location { get; set; }
        public string Availability { get; set; }
        public decimal Price { get; set; }
        public int Hight { get; set; }
        public int Width { get; set; }
    }
}