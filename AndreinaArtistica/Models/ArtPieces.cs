namespace AndreinaArtistica.Models
{
    public class ArtPieces
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Soporte { get; set; }
        public DateTime Fecha { get; set; }
        public string Tematica1 { get; set; }
        public string? Tematica2 { get; set; }
        public string Ubicacion { get; set; }
        public string Disponibilidad { get; set; }
        public int Precio { get; set; }
    }
}