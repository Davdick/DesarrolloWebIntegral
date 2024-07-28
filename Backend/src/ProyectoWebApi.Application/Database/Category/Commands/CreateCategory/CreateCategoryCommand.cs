using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Category;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.CreateCategory
{
    public class CreateCategoryCommand : ICreateCategoryCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public async Task<CreateCategoryModel> Execute(CreateCategoryModel model)
        {
            var entity = _mapper.Map<CategoryEntity>(model);
            await _databaseService.Category.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
