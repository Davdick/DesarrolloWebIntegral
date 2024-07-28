using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.DeleteComment
{
    public class DeleteComment : IDeleteComment
    {
        private readonly IDatabaseService _databaseService;

        public DeleteComment(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public async Task<bool> Execute(int commentId)
        {
            var entity = await _databaseService.CommentEntity.FirstOrDefaultAsync(x => x.IdComment == commentId);
            if (entity == null)
                return false;
            _databaseService.CommentEntity.Remove(entity);
            return await _databaseService.SaveAsync();
        }
    }
}
