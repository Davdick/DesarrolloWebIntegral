namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.UdateBusiness
{
    public class UpdateBusinessModel
    {
        public int IdBusiness { get; set; }
        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
