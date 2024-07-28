using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration
{
    public class CategoryConfiguration
    {
        public CategoryConfiguration(EntityTypeBuilder<CategoryEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdCategory);
            entityTypeBuilder.Property(x => x.CategoryName);
            entityTypeBuilder.Property(x => x.CategoryDescription);

            entityTypeBuilder.HasMany(x => x.Businesses)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);

        }
    }
}
