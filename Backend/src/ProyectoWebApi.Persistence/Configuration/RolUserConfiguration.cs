using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration
{
    public class RolUserConfiguration
    {
        public RolUserConfiguration(EntityTypeBuilder<RolUserEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdRolUser);
            entityTypeBuilder.Property(x => x.Rol);
            entityTypeBuilder.Property(x => x.Description);

            entityTypeBuilder.HasMany(x => x.Users)
                .WithOne(x => x.Rol)
                .HasForeignKey(x => x.RolId);
                
        }
    }
}
