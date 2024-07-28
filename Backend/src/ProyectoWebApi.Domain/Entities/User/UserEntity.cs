using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User
{
    public class UserEntity
    {
        public int IdUser { get; set; }
        public int RolId {  get; set; }
        public string Nickname { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RolUserEntity Rol {  get; set; }
        public ICollection<BusinessEntity> Businesses { get; set; }
        public ICollection<CommentEntity> Comments { get; set; }


    }
}
