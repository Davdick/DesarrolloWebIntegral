using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.DeleteProduct
{
    public class DeleteProductCommand : IDeleteProductCommand
    {
        private readonly IDatabaseService _databaseService;

        public DeleteProductCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<bool> Execute(int productId)
        {
            var entity = await _databaseService.ProductEntity.FirstOrDefaultAsync(x => x.IdProduct == productId);
            if (entity == null)
                return false;
            _databaseService.ProductEntity.Remove(entity);
            return await _databaseService.SaveAsync();
        }
    }
}
