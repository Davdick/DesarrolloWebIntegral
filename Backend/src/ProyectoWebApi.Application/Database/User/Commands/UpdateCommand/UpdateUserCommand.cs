using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.User;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.UpdateCommand
{
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public UpdateUserCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<UpdateUserModel> Execute(UpdateUserModel model)
        {
            var entity = _mapper.Map<UserEntity>(model);
            _databaseService.User.Update(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
