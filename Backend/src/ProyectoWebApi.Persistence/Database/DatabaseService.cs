using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;
using ProyectoWebApi.DesarrolloIntegral.Persistence.Configuration;
using System.Reflection.Emit;

namespace ProyectoWebApi.DesarrolloIntegral.Persistence.Database
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        public DatabaseService(DbContextOptions options) : base(options)
        {

        } 
        public DbSet<BusinessEntity> Business { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductEntity> ProductEntity { get; set; }
        public DbSet<RolUserEntity> RolUser { get; set; }
        public DbSet<CommentEntity> CommentEntity { get; set; }
        public DbSet<UserEntity> User { get; set; }

        public async Task<bool> SaveAsync() { return await SaveChangesAsync() > 0; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }
        //APLICA CONFIGURACIONES DE ENTIDADES
        private void EntityConfiguration(ModelBuilder modelBuilder) 
        {
            new BusinessConfiguration(modelBuilder.Entity<BusinessEntity>());
            new CategoryConfiguration(modelBuilder.Entity<CategoryEntity>());
            new CommentConfiguration(modelBuilder.Entity<CommentEntity>());
            new ProductConfiguration(modelBuilder.Entity<ProductEntity>());
            new RolUserConfiguration(modelBuilder.Entity<RolUserEntity>());
            new UserConfiguration(modelBuilder.Entity<UserEntity>());

        }
    }
}
