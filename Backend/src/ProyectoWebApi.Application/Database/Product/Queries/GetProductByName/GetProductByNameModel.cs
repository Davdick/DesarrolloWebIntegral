namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName
{
    public class GetProductByNameModel
    {
        public int IdProduct { get; set; }
        public int BusinessId { get; set; }
        public string ServiceProductName { get; set; }
        public string Description { get; set; }
    }
}
