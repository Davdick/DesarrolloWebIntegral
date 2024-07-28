using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IDeleteCategoryCommand
    {
        private readonly IDatabaseService _databaseService;

        public DeleteCategoryCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<bool> Execute(int categoryId)
        {
            var entity = await _databaseService.Category.FirstOrDefaultAsync(x => x.IdCategory == categoryId);
            if (entity == null)
                return false;
            _databaseService.Category.Remove(entity);
            return await _databaseService.SaveAsync();
        }
    }
}
