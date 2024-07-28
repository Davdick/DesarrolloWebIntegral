using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment
{
    public class CommentEntity
    {
        public int IdComment { get; set; }
        public int UserId { get; set; }
        public int BusinessId { get; set; }
        public string Comment { get; set; }
        public UserEntity User { get; set; }
        public BusinessEntity Business { get; set; }
    }
}
