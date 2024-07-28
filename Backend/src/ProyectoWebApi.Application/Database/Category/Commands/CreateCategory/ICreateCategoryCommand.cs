namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.CreateCategory
{
    public interface ICreateCategoryCommand
    {
        Task<CreateCategoryModel> Execute(CreateCategoryModel model);
    }
}
