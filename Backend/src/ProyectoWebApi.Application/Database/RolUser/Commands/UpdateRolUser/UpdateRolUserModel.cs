using AutoMapper;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.UpdateRolUser
{
    public class UpdateRolUserModel
    {
        public int IdRolUser { get; set; }
        public string Rol { get; set; }
        public string Description { get; set; }
    }
}
