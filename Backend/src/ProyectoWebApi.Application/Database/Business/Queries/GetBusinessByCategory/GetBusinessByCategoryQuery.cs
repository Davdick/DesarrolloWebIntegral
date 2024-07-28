using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory
{
    public class GetBusinessByCategoryQuery : IGetBusinessByCategoryQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetBusinessByCategoryQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<GetBusinessByCategoryModel> Execute(int categoryId)
        {
            var entity = await _databaseService.Business.FirstOrDefaultAsync(x => x.CategoryId == categoryId);
            return _mapper.Map<GetBusinessByCategoryModel>(entity);
        }
    }
}
