using AndreinaArtistica.Models;

namespace AndreinaArtistica.Resources.Abstract
{
    public interface IMaterialsResource
    {
        public Task<IEnumerable<MaterialViewModel>> GetMaterials();
    }
}