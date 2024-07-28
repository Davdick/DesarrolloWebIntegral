namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Queries.GetAllCategories
{
    public interface IGetAllCategoriesQuery
    {
        Task<List<GetAllCategoriesModel>> Execute();
    }
}
