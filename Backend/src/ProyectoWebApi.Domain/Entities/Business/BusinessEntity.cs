using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business
{
    public class BusinessEntity
    {
        public int IdBusiness { get; set; }
        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public UserEntity Owner { get; set; }
        public CategoryEntity Category { get; set; }
        public ICollection<CommentEntity> Comments { get; set; }
        public ICollection<ProductEntity> Products { get; set; }

    }
}
