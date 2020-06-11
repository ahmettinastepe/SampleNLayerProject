using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SampleNLayerProject.Core.Entities;

namespace SampleNLayerProject.Data.Configurations
{
    public class SolusyonConfiguration : IEntityTypeConfiguration<Solusyon>
    {
        public void Configure(EntityTypeBuilder<Solusyon> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).UseIdentityColumn();
            builder.Property(x => x.volume).IsRequired();
            builder.Property(x => x.doktorMiktar).IsRequired();
            builder.Property(x => x.solusyonTipId).IsRequired();
            builder.Property(x => x.solusyonId).IsRequired();
            builder.Property(x => x.birim).IsRequired();
            builder.ToTable("Solusyon");
        }
    }
}