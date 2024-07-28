using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database
{
    public interface IDatabaseService
    {
        public DbSet<BusinessEntity> Business { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductEntity> ProductEntity { get; set; }
        public DbSet<RolUserEntity> RolUser { get; set; }
        public DbSet<CommentEntity> CommentEntity { get; set; }
        public DbSet<UserEntity> User { get; set; }
        Task<bool> SaveAsync();

    }
}
