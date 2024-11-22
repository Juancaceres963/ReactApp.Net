namespace AndreinaArtistica.Models.DB
{
    public partial class MaxPrice
    {
        public decimal Price { get; set; }

        public virtual ICollection<ArtPiece> ArtPieces { get; set; } = new List<ArtPiece>();
    }
}