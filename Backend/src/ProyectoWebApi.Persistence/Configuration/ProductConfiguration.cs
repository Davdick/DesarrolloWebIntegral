using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<ProductEntity>entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdProduct);
            entityTypeBuilder.Property(x => x.BusinessId);
            entityTypeBuilder.Property(x => x.ServiceProductName);
            entityTypeBuilder.Property(x => x.Description);

            entityTypeBuilder.HasOne(x => x.Business)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.BusinessId);

        }
    }
}
