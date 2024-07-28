namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Queries.GetCommentsByBusiness
{
    public interface IGetCommentsByBusinessQuery
    {
        Task<List<GetCommentsByBusinessModel>> Execute(int businessId);
    }
}
