namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory
{
    public interface IGetBusinessByCategoryQuery
    {
        Task<GetBusinessByCategoryModel> Execute(int categoryId);
    }
}
