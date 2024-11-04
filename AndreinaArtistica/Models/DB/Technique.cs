namespace AndreinaArtistica.Models.DB
{
    public partial class Technique
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public virtual ICollection<ArtPiece> ArtPieces { get; set; } = new List<ArtPiece>();
    }
}
