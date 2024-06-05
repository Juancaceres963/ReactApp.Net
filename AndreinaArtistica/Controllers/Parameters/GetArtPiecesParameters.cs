namespace AndreinaArtistica.Controllers.Parameters
{
    public class GetArtPiecesParameters
    {
        public IEnumerable<int?> Ids { get; set; }
        public bool? Availability {  get; set; }
        public int? Top { get; set; }
        public int? Skip { get; set; }
        public DateTime Elaborated { get; set; }
    }
}
