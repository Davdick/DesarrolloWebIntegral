namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness
{
    public interface IGetProductsByBusinessQuery
    {
        Task<GetProductsByBusinessModel> Execute(int businessId);
    }
}
