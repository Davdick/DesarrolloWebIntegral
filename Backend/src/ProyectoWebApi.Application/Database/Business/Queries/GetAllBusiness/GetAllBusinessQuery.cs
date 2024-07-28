using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetAllBusiness
{
    public class GetAllBusinessQuery : IGetAllBusinessQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetAllBusinessQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<List<GetAllBusinessModel>> Execute()
        {
            var listEntities = await _databaseService.Business.ToListAsync();
            return _mapper.Map<List<GetAllBusinessModel>>(listEntities);
        }
    }
}
