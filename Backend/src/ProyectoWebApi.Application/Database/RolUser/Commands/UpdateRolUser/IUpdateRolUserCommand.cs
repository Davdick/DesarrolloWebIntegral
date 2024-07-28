namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.UpdateRolUser
{
    public interface IUpdateRolUserCommand
    {
        Task<UpdateRolUserModel> Execute(UpdateRolUserModel model);
    }
}
