using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleNLayerProject.Core.Entities;

namespace SampleNLayerProject.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.orderId);
            builder.Property(x => x.orderId).UseIdentityColumn();
            builder.Property(x => x.dosyaNo).IsRequired();
            builder.Property(x => x.hastaTCKimlikNo).IsRequired();
            builder.Property(x => x.hastaAdi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.hastaSoyadi).IsRequired().HasMaxLength(50);
            builder.Property(x => x.orderTarihSaat).IsRequired();
            builder.Property(x => x.hastaTipi).IsRequired();
            builder.Property(x => x.klinikAdi).IsRequired();
            builder.Property(x => x.orderVerenDoktorAdSoyad).IsRequired().HasMaxLength(100);
            builder.ToTable("Orders");
        }
    }
}
