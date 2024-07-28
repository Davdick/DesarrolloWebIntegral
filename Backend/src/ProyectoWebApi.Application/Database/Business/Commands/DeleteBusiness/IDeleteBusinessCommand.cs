namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.DeleteBusiness
{
    public interface IDeleteBusinessCommand
    {
        Task<bool> Execute(int businessId);
    }
}
