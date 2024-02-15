﻿namespace AndreinaArtistica.Models.DB;

public partial class ArtPiece
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Category { get; set; }

    public int Material { get; set; }

    public DateOnly? Elaborated { get; set; }

    public int Topic { get; set; }

    public int? SubTopic { get; set; }

    public string? Ubication { get; set; }

    public string? Exhibited { get; set; }

    public string Availability { get; set; } = null!;

    public string? State { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int Price { get; set; }

    public virtual Category CategoryNavigation { get; set; } = null!;

    public virtual Material MaterialNavigation { get; set; } = null!;

    public virtual Subject TopicNavigation { get; set; } = null!;
}