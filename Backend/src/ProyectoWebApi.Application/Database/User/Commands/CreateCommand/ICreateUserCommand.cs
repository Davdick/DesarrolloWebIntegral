namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand
{
    public interface ICreateUserCommand
    {
        Task<CreateUserModel> Execute(CreateUserModel model);
    }
}
