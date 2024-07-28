namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment
{
    public interface ICreateCommentCommand
    {
        Task<CreateCommentModel> Execute(CreateCommentModel model);
    }
}
