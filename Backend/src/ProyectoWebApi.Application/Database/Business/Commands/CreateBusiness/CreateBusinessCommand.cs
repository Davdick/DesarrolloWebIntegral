using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Business;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.CreateBusinessModel
{
    public class CreateBusinessCommand : ICreateBusinessCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public async Task<CreateBusinessModel> Execute(CreateBusinessModel model)
        {
            var entity = _mapper.Map<BusinessEntity>(model);
            await _databaseService.Business.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;




        }
    }
}
