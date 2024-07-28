namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.UdateBusiness
{
    public interface IUpdateBusinessCommand
    {
        Task<UpdateBusinessModel> Execute(UpdateBusinessModel model);
    }
}
