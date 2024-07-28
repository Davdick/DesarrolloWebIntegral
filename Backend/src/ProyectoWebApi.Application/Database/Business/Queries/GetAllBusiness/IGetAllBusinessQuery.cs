namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetAllBusiness
{
    public interface IGetAllBusinessQuery
    {
        Task<List<GetAllBusinessModel>> Execute();
    }
}
