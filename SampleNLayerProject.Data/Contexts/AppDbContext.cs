using Microsoft.EntityFrameworkCore;
using SampleNLayerProject.Core.Entities;
using SampleNLayerProject.Data.Configurations;
using SampleNLayerProject.Data.Seeds;

namespace SampleNLayerProject.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new SolusyonConfiguration());

            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));

            //modelBuilder.Entity<Order>().HasMany(x => x.solusyonBilgisi).WithOne(c => c.order).HasForeignKey(x => x.orderId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Solusyon>().HasOne(x => x.order).WithMany(x => x.solusyonBilgisi).HasForeignKey(x => x.orderId).OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}