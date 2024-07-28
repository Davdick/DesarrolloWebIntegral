using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category
{
    public class CategoryEntity
    {
        public int IdCategory { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<BusinessEntity> Businesses { get; set; }
        
    }
}
