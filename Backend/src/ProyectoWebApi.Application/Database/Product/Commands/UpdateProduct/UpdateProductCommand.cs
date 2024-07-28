using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Product;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct
{
    public class UpdateProductCommand : IUpdateProductCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public UpdateProductCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<UpdateProductModel> Execute(UpdateProductModel model)
        {
            var entity = _mapper.Map<ProductEntity>(model);
            _databaseService.ProductEntity.Update(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
