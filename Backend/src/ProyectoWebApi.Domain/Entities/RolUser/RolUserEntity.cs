using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser
{
    public class RolUserEntity
    {
        public int IdRolUser { get; set; }
        public string Rol { get; set; }
        public string Description { get; set; }

        public ICollection<UserEntity> Users { get; set; }
    }
}
