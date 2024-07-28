using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.CreateRolUser
{
    public interface ICreateRolUserCommand
    {
        Task<CreateRolUserModel> Execute(CreateRolUserModel model);
    }
}
