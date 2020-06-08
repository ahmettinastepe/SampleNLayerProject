using Microsoft.EntityFrameworkCore;
using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Data.Contexts;
using System.Threading.Tasks;

namespace SampleNLayerProject.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext appDbContext { get; }

        public ProductRepository(AppDbContext context) : base(context) { }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await appDbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == productId);
        }
    }
}