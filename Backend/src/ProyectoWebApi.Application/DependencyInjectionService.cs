using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProyectoWebApi.DesarrolloIntegral.Application.Configuration;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.CreateBusinessModel;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.DeleteBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.UdateBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetAllBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByName;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.CreateCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.DeleteCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.UpdateCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Queries.GetAllCategories;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.DeleteComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Queries.GetCommentsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.DeleteProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.CreateRolUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.DeleteRlUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.UpdateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Queries.GetUserLogin;

namespace ProyectoWebApi.DesarrolloIntegral.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());
            services.AddTransient<ICreateBusinessCommand, CreateBusinessCommand>();
            services.AddTransient<ICreateCategoryCommand, CreateCategoryCommand>();
            services.AddTransient<ICreateCommentCommand, CreateCommentCommand>();
            services.AddTransient<ICreateProductCommand, CreateProductCommand>();
            services.AddTransient<ICreateRolUserCommand, CreateRolUserCommand>();
            services.AddTransient<ICreateUserCommand, CreateUserCommand>();
            services.AddTransient<IUpdateBusinessCommand, UpdateBusinessCommand>();
            services.AddTransient<IDeleteBusinessCommand, DeleteBusinessCommand>();
            services.AddTransient<IUpdateCategoryCommand, UpdateCategoryCommand>();
            services.AddTransient<IDeleteCategoryCommand, DeleteCategoryCommand>();
            services.AddTransient<IUpdateCommentCommand, UpdateCommentCommand>();
            services.AddTransient<IDeleteComment, DeleteComment>();
            services.AddTransient<IUpdateProductCommand, UpdateProductCommand>();
            services.AddTransient<IDeleteProductCommand, DeleteProductCommand>();
            services.AddTransient<IDeleteRolUserCommand, DeleteRolUserCommand>();
            services.AddTransient<IUpdateUserCommand, UpdateUserCommand>();
            services.AddTransient<IGetAllBusinessQuery, GetAllBusinessQuery>();
            services.AddTransient<IGetBusinessByCategoryQuery, GetBusinessByCategoryQuery>();
            services.AddTransient<IGetBusinessByIdQuery, GetBusinessByIdQuery>();
            services.AddTransient<IGetBusinessByNameQuery, GetBusinessByNameQuery>();
            services.AddTransient<IGetAllCategoriesQuery, GetAllCategoriesQuery>();
            services.AddTransient<IGetCommentsByBusinessQuery, GetCommentsByBusinessQuery>();
            services.AddTransient<IGetProductsByBusinessQuery, GetProductsByBusinessQuery>();
            services.AddTransient<IGetProductByNameQuery, GetProductByNameQuery>();
            services.AddTransient<IGetUserLoginQuery, GetUserLoginQuery>();

            return services;
        }
    }
}
