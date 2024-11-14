using System.ComponentModel;

namespace AndreinaArtistica.Controllers.Parameters
{
    public class ArtPieceQueryParameters
    {
        public IEnumerable<int>? Ids { get; set; }

        public IEnumerable<int>? Categories { get; set; }

        public IEnumerable<int>? Topics { get; set; }

        public IEnumerable<int>? Techniques { get; set; }

        public bool? Availability { get; set; }

        [DefaultValue(null)]
        public decimal? MaxPrice { get; set; }

        [DefaultValue(null)]
        public decimal? MinPrice { get; set; }

        [DefaultValue(100)]
        public int Top { get; set; } = 20;

        [DefaultValue(0)]
        public int Skip { get; set; } = 0;

        public string OrderBy { get; set; } = "elaborated desc";
    }
}
