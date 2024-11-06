namespace AndreinaArtistica.Models.DB;

public partial class Topic
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Topic> Topics { get; set; } = new List<Topic>();
}
