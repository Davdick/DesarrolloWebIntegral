using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.CreateRolUser
{
    public class CreateRolUserCommand : ICreateRolUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public async Task<CreateRolUserModel> Execute(CreateRolUserModel model)
        {
            var entity = _mapper.Map<RolUserEntity>(model);
            await _databaseService.RolUser.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }

    }
}
