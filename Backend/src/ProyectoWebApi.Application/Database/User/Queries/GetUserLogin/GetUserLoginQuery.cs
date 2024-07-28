using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Queries.GetUserLogin
{
    public class GetUserLoginQuery : IGetUserLoginQuery
    {
        private readonly IDatabaseService _databaseService;
        

        public GetUserLoginQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
            
        }
        public async Task<GetUserLoginModel> Execute(GetUserLoginModel model)
        {
            var entity = await _databaseService.User.FirstOrDefaultAsync(x => x.Nickname == model.Nickname && x.Password == model.Password);
            if (entity == null)
            {
                GetUserLoginModel modelF = new GetUserLoginModel
                {
                    Nickname = "NotFound or Incorrect",
                    Password = "NotFound or Incorrect"
                };
                return modelF;
            }
            GetUserLoginModel res = new GetUserLoginModel
            {
                Nickname = entity.Nickname,
                Password = entity.Password
            };
            return res;
        }
    }
}
