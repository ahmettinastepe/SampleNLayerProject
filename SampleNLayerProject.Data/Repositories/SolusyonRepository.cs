using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Core.Repositories;
using SampleNLayerProject.Data.Contexts;

namespace SampleNLayerProject.Data.Repositories
{
    class SolusyonRepository : Repository<Solusyon>, ISolusyonRepository
    {
        public SolusyonRepository(AppDbContext context) : base(context) { }
    }
}