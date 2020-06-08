using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleNLayerProject.Core.Entities;

namespace SampleNLayerProject.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Pilot Kalem", Price = 8.25m, Stock = 20, CategoryId = _ids[0] },
                new Product { Id = 2, Name = "Tükenmez Kalem", Price = 9m, Stock = 90, CategoryId = _ids[0] },
                new Product { Id = 3, Name = "Kurşun Kalem", Price = 1m, Stock = 200, CategoryId = _ids[0] },
                new Product { Id = 4, Name = "Kareli Defter", Price = 2.50m, Stock = 150, CategoryId = _ids[1] }
            );
        }
    }
}