using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.CreateBusinessModel;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.UdateBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetAllBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByName;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.CreateCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.UpdateCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.CreateRolUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.UpdateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Queries.GetUserLogin;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Business
            CreateMap<BusinessEntity, CreateBusinessModel>();
            CreateMap<BusinessEntity, UpdateBusinessModel>();
            CreateMap<BusinessEntity, GetAllBusinessModel>();
            CreateMap<BusinessEntity, GetBusinessByCategoryModel>();
            CreateMap<BusinessEntity, GetBusinessByIdModel>();
            CreateMap<BusinessEntity, GetBusinessByNameModel>();
            #endregion
            #region Category
            CreateMap<CategoryEntity, CreateCategoryModel>();
            CreateMap<CategoryEntity, UpdateCategoryModel>();
            #endregion
            #region Comment
            CreateMap<CommentEntity, CreateCommentModel>();
            CreateMap<CommentEntity, UpdateCommentModel>();
            #endregion
            #region Product
            CreateMap<ProductEntity, CreateProductModel>();
            CreateMap<ProductEntity, UpdateProductModel>();
            CreateMap<ProductEntity, GetProductsByBusinessModel>();
            CreateMap<ProductEntity, GetProductByNameModel>();
            #endregion
            #region RolUser
            CreateMap<RolUserEntity, CreateRolUserModel>();
            #endregion
            #region User
            CreateMap<UserEntity, CreateUserModel>();
            CreateMap<UserEntity, UpdateUserModel>();
            //CreateMap<UserEntity, GetUserLoginQuery>();
            #endregion
        }
    }
}
