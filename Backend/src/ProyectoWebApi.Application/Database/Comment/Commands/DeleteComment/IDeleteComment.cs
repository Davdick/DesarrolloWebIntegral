namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.DeleteComment
{
    public interface IDeleteComment
    {
        Task<bool> Execute(int commentId);
    }
}
