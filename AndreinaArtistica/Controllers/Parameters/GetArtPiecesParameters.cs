using System.ComponentModel;
using static AndreinaArtistica.Models.Enums.ArtPieceEnums;

namespace AndreinaArtistica.Controllers.Parameters
{
    public class ArtPieceQueryParameters
    {
        public Topic? Topic { get; set; }

        public bool? Availability { get; set; }

        [DefaultValue(null)]
        public decimal? MaxPrice { get; set; }

        [DefaultValue(null)]
        public decimal? MinPrice { get; set; }

        [DefaultValue(100)]
        public int Top { get; set; } = 100;

        [DefaultValue(0)]
        public int Skip { get; set; } = 0;

        public string SortBy { get; set; } = "elaborated";

        public IEnumerable<int>? Ids { get; set; }
    }
}
