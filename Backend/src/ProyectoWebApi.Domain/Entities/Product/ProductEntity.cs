using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product
{
    public class ProductEntity
    {
        public int IdProduct { get; set; }
        public int BusinessId { get; set; }
        public string ServiceProductName {  get; set; }
        public string Description { get; set; }
        public BusinessEntity Business { get; set; }
    }
}
