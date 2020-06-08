using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Core.UnitOfWorks;
using SampleNLayerProject.Data.Contexts;
using SampleNLayerProject.Data.Repositories;
using System.Threading.Tasks;

namespace SampleNLayerProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_appDbContext);
        public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}