using Microsoft.EntityFrameworkCore;
using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Data.Contexts;
using System.Threading.Tasks;

namespace SampleNLayerProject.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext appDbContext { get; }

        public CategoryRepository(AppDbContext context) : base(context) { }

        public async Task<Category> GetWithProductByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}