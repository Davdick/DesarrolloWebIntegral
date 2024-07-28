namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.UpdateCommand
{
    public interface IUpdateUserCommand
    {
        Task<UpdateUserModel> Execute(UpdateUserModel model);
    }
}
