using SampleNLayerProject.Core.Repositories;
using System.Threading.Tasks;

namespace SampleNLayerProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        ISolusyonRepository Solusyons { get; }

        Task CommitAsync();
        void Commit();
    }
}