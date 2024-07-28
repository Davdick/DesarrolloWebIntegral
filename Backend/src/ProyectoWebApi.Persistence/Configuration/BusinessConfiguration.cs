using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration
{
    public class BusinessConfiguration
    {
        public BusinessConfiguration(EntityTypeBuilder<BusinessEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdBusiness);
            entityTypeBuilder.Property(x => x.OwnerId).IsRequired();
            entityTypeBuilder.Property(x => x.CategoryId).IsRequired();
            entityTypeBuilder.Property(x => x.Title).IsRequired();
            entityTypeBuilder.Property(x => x.Description).IsRequired();

            entityTypeBuilder.HasOne(x => x.Owner)
                .WithMany(x => x.Businesses)
                .HasForeignKey(x => x.OwnerId);

            entityTypeBuilder.HasOne(x => x.Category)
                .WithMany(x => x.Businesses)
                .HasForeignKey(x => x.CategoryId);

            entityTypeBuilder.HasMany(x => x.Comments)
                .WithOne(x => x.Business)
                .HasForeignKey(x => x.BusinessId);

            entityTypeBuilder.HasMany(x => x.Products)
                .WithOne(x => x.Business)
                .HasForeignKey(x => x.BusinessId);  

        }
    }
}
