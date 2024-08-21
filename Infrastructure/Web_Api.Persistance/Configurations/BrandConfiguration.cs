using Bogus;
using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web_Api.Domain.Entities;
/*
 Veritabanı tablosundaki verilere “HasMaxLength()”,”IsRequired()”,”UseIdentityColumn()”,”HasKey”. gibi özellikler
vermek için IEntityTypeConfiguration methodu kullanılır.
 */


namespace Web_Api.Persistance.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);//Name max 256 karakter.

            Faker faker = new("tr");//Sahte veri oluşturmak için bogus paketinde faker kütüphanesi kulanılır.

            Brand brand1 = new()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                CreatedDate= DateTime.Now,
                IsDeleted = false,
            };

            Brand brand2 = new()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Brand brand3 = new()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };

            Brand brand4 = new()
            {
                Id = 4,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            builder.HasData(brand1, brand2, brand3, brand4);
        }
    }
}
