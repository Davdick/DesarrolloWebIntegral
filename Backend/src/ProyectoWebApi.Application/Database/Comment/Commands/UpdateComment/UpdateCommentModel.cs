using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment
{
    public class UpdateCommentModel
    {
        public int IdComment { get; set; }
        public int UserId { get; set; }
        public int BusinessId { get; set; }
        public string Comment { get; set; }
    }
}
