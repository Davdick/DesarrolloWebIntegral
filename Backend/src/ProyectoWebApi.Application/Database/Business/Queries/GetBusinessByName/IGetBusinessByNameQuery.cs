namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByName
{
    public interface IGetBusinessByNameQuery
    {
        Task<GetBusinessByNameModel> Execute(string name);
    }
}
