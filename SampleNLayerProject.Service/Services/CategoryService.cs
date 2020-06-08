using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Core.Services;
using SampleNLayerProject.Core.UnitOfWorks;
using System.Threading.Tasks;

namespace SampleNLayerProject.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository) { }
        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await UnitOfWork.Categories.GetWithProductByIdAsync(categoryId);
        }
    }
}