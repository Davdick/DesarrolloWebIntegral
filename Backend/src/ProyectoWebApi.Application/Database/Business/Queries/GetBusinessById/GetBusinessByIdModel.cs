namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById
{
    public class GetBusinessByIdModel
    {
        public int IdBusiness { get; set; }
        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
