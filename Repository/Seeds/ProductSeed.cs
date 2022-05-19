using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId=1, Price=10, Stock=20, CreatedDate  = DateTime.Now, Name = "Kalem 1" },
                new Product { Id = 2, CategoryId=1, Price=20, Stock=30, CreatedDate  = DateTime.Now, Name = "Kalem 2" },
                new Product { Id = 3, CategoryId=1, Price=30, Stock=40, CreatedDate  = DateTime.Now, Name = "Kalem 3" },               
                new Product { Id = 4, CategoryId=2, Price=40, Stock=50, CreatedDate  = DateTime.Now, Name = "Kitap 1" }   ,          
                new Product { Id = 5, CategoryId=2, Price=50, Stock=60, CreatedDate  = DateTime.Now, Name = "Kitap 2" }             
                );
        }
    }
}
