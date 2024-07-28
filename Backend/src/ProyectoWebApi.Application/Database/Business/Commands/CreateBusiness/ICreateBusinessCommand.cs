namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.CreateBusinessModel
{
    public interface ICreateBusinessCommand
    {
        Task<CreateBusinessModel> Execute(CreateBusinessModel model);
    }
}
