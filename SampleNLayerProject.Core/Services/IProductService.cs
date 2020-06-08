using SampleNLayerProject.Core.Entities;
using System.Threading.Tasks;

namespace SampleNLayerProject.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
    }
}