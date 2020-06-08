using SampleNLayerProject.Core.Entities;
using System.Threading.Tasks;

namespace SampleNLayerProject.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}