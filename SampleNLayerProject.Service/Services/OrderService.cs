using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Core.Services;
using SampleNLayerProject.Core.UnitOfWorks;

namespace SampleNLayerProject.Service.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork, IRepository<Order> repository) : base(unitOfWork, repository) { }
    }
}