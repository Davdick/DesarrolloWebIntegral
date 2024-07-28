using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName
{
    public class GetProductByNameQuery : IGetProductByNameQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetProductByNameQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<GetProductByNameModel> Execute(string name)
        {
            var entity = await _databaseService.ProductEntity.FirstOrDefaultAsync(x => x.ServiceProductName == name);
            return _mapper.Map<GetProductByNameModel>(entity);
        }
    }
}
