using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Data.Contexts;

namespace SampleNLayerProject.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context) { }
    }
}