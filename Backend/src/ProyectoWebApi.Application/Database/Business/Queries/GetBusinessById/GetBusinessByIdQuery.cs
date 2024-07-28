using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById
{
    public class GetBusinessByIdQuery :IGetBusinessByIdQuery
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;
        public GetBusinessByIdQuery(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }

        public async Task<GetBusinessByIdModel> Execute(int Id)
        {
            var entity = await _databaseService.Business.FirstOrDefaultAsync(x => x.IdBusiness == Id);
            return _mapper.Map<GetBusinessByIdModel>(entity);
        }
    }
}
