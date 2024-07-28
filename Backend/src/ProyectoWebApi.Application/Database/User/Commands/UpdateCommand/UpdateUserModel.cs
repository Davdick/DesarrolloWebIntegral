namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.UpdateCommand
{
    public class UpdateUserModel
    {
        public int IdUser { get; set; }
        public int RolId { get; set; }
        public string Nickname { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
