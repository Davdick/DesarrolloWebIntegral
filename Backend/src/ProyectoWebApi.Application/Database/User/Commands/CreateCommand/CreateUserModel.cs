using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand
{
    public class CreateUserModel
    {
        public int RolId { get; set; }
        public string Nickname { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
