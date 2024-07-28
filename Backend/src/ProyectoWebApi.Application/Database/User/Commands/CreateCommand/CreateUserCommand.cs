using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.CreateRolUser;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public CreateUserCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<CreateUserModel> Execute(CreateUserModel model)
        {
            var entity = _mapper.Map<UserEntity>(model);
            await _databaseService.User.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
