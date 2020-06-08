using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Core.Services;
using SampleNLayerProject.Core.UnitOfWorks;
using System.Threading.Tasks;

namespace SampleNLayerProject.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository) { }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await UnitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}