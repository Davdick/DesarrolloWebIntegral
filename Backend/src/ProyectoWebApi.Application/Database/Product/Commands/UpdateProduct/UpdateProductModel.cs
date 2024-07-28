namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct
{
    public class UpdateProductModel
    {
        public int IdProduct { get; set; }
        public int BusinessId { get; set; }
        public string ServiceProductName { get; set; }
        public string Description { get; set; }
    }
}
