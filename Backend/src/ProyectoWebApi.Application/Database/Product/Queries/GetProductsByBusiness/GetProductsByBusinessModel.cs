namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness
{
    public class GetProductsByBusinessModel
    {
        public int IdProduct { get; set; }
        public int BusinessId { get; set; }
        public string ServiceProductName { get; set; }
        public string Description { get; set; }
    }
}
