namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment
{
    public class CreateCommentModel
    {
        public int UserId { get; set; }
        public int BusinessId { get; set; }
        public string Comment { get; set; }
    }
}
