using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.DeleteBusiness
{
    public class DeleteBusinessCommand : IDeleteBusinessCommand
    {
        private readonly IDatabaseService _databaseService;
        public DeleteBusinessCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<bool> Execute(int businessId)
        {
            var entity = await _databaseService.Business.FirstOrDefaultAsync(x => x.IdBusiness == businessId);
            if (entity == null)
                return false;
            _databaseService.Business.Remove(entity);
            return await _databaseService.SaveAsync();
        }
    }
}
