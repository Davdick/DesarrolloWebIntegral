using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdUser);
            entityTypeBuilder.Property(x => x.RolId);
            entityTypeBuilder.Property(x => x.Nickname);
            entityTypeBuilder.Property(x => x.UserName);
            entityTypeBuilder.Property(x => x.LastName);
            entityTypeBuilder.Property(x => x.Email);
            entityTypeBuilder.Property(x => x.Password);

            entityTypeBuilder.HasOne(x => x.Rol)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.RolId);

            entityTypeBuilder.HasMany(x => x.Businesses)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId);

            entityTypeBuilder.HasMany(x => x.Comments)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

        }
    }
}
