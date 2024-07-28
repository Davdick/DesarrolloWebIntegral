namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment
{
    public interface IUpdateCommentCommand
    {
        Task<UpdateCommentModel> Execute(UpdateCommentModel model);
    }
}
