using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.UdateBusiness
{
    public class UpdateBusinessCommand : IUpdateBusinessCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public UpdateBusinessCommand(IDatabaseService dataBaseService, IMapper mapper)
        {
            _databaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<UpdateBusinessModel> Execute(UpdateBusinessModel model)
        {
            var entity = _mapper.Map<BusinessEntity>(model);
            _databaseService.Business.Update(entity);
            await _databaseService.SaveAsync();
            return model;

        }
    }
}
