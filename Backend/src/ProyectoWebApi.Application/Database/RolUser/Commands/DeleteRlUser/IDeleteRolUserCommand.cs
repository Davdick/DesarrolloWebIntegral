namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.DeleteRlUser
{
    public interface IDeleteRolUserCommand
    {
        Task<bool> Execute(int rolUserId);
    }
}
