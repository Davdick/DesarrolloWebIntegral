namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById
{
    public interface IGetBusinessByIdQuery
    {
        Task<GetBusinessByIdModel> Execute(int Id);
    }
}
