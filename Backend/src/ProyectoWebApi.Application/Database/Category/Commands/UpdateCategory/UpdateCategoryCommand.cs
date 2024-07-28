using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IUpdateCategoryCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public UpdateCategoryCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<UpdateCategoryModel> Execute(UpdateCategoryModel model)
        {
            var entity = _mapper.Map<CategoryEntity>(model);
            _databaseService.Category.Update(entity);
            await _databaseService.SaveAsync();
            return model;

        }
    }
}
