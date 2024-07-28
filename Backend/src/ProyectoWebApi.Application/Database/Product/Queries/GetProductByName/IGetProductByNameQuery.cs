namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName
{
    public interface IGetProductByNameQuery
    {
        Task<GetProductByNameModel> Execute(string name);
    }
}
