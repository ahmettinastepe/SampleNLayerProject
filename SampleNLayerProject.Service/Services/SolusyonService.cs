using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Core.Services;
using SampleNLayerProject.Core.UnitOfWorks;

namespace SampleNLayerProject.Service.Services
{
    public class SolusyonService : Service<Solusyon>, ISolusyonService
    {
        public SolusyonService(IUnitOfWork unitOfWork, IRepository<Solusyon> repository) : base(unitOfWork, repository) { }
    }
}