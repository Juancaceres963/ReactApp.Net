using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface IMaxPriceResource
    {
        public Task<IEnumerable<MaxPriceViewModel>> GetMaxPrice();
    }
}