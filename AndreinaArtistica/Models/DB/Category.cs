﻿namespace AndreinaArtistica.Models.DB;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ArtPiece> ArtPieces { get; set; } = new List<ArtPiece>();
}
