using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.RolUser;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.UpdateRolUser
{
    public class UpdateRolUserCommand : IUpdateRolUserCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public UpdateRolUserCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<UpdateRolUserModel> Execute(UpdateRolUserModel model)
        {
            var entity = _mapper.Map<RolUserEntity>(model);
            _databaseService.RolUser.Update(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
