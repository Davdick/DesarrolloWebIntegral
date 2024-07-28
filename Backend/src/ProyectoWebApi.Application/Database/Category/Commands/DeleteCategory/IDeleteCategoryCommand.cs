namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.DeleteCategory
{
    public interface IDeleteCategoryCommand
    {
        Task<bool> Execute(int categoryId);
    }
}
