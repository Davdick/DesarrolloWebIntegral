namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.UpdateCategory
{
    public interface IUpdateCategoryCommand
    {
        Task<UpdateCategoryModel> Execute(UpdateCategoryModel model);
    }
}
