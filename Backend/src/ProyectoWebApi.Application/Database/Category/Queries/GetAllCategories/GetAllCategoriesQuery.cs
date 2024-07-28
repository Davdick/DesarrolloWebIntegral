using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetAllBusiness;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Queries.GetAllCategories
{
    public class GetAllCategoriesQuery : IGetAllCategoriesQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllCategoriesQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllCategoriesModel>> Execute()
        {
            var listEntities = await _databaseService.Category.ToListAsync();
            return _mapper.Map<List<GetAllCategoriesModel>>(listEntities);
        }
    }
}
