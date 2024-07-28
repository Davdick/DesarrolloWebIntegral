namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Queries.GetUserLogin
{
    public interface IGetUserLoginQuery
    {
       Task<GetUserLoginModel> Execute(GetUserLoginModel model);
    }
}
