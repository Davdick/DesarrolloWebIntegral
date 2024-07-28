using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.DeleteRlUser
{
    public class DeleteRolUserCommand : IDeleteRolUserCommand
    {
        private readonly IDatabaseService _databaseService;

        public DeleteRolUserCommand(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<bool> Execute(int rolUserId)
        {
            var entity = await _databaseService.RolUser.FirstOrDefaultAsync(x => x.IdRolUser == rolUserId);
            if (entity == null)
                return false;
            _databaseService.RolUser.Remove(entity);
            return await _databaseService.SaveAsync();
        }
    }
}
