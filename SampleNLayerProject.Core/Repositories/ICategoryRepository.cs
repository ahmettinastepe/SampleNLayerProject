using SampleNLayerProject.Core.Entities;
using System.Threading.Tasks;

namespace SampleNLayerProject.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithProductByIdAsync(int categoryId);
    }
}