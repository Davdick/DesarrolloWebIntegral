using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct
{
    public class CreateProductCommand : ICreateProductCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public async Task<CreateProductModel> Execute(CreateProductModel model)
        {
            var entity = _mapper.Map<ProductEntity>(model);
            await _databaseService.ProductEntity.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
