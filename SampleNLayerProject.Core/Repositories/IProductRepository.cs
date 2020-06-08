using SampleNLayerProject.Core.Entities;
using System.Threading.Tasks;

namespace SampleNLayerProject.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}