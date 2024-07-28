using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration
{
    public class CommentConfiguration
    {
        public CommentConfiguration(EntityTypeBuilder<CommentEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.IdComment);
            entityTypeBuilder.Property(x => x.IdComment);
            entityTypeBuilder.Property(x => x.UserId);
            entityTypeBuilder.Property(x => x.BusinessId);
            entityTypeBuilder.Property(x => x.Comment);

            entityTypeBuilder.HasOne(x => x.User)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.UserId);

            entityTypeBuilder.HasOne(x => x.Business)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.BusinessId);


        }
    }
}
