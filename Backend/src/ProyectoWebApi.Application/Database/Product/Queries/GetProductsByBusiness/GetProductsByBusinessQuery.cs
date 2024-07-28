using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness
{
    public class GetProductsByBusinessQuery : IGetProductsByBusinessQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetProductsByBusinessQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<GetProductsByBusinessModel> Execute(int businessId)
        {
            var entity = await _databaseService.ProductEntity.FirstOrDefaultAsync(x => x.BusinessId == businessId);
            return _mapper.Map<GetProductsByBusinessModel>(entity);
        }
    }
}
