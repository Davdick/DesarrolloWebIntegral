using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByName
{
    public class GetBusinessByNameQuery : IGetBusinessByNameQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public GetBusinessByNameQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<GetBusinessByNameModel> Execute(string name)
        {
            var entity = await _databaseService.Business.FirstOrDefaultAsync(x => x.Title == name);
            return _mapper.Map<GetBusinessByNameModel>(entity);
        }
    }
}
