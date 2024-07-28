using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment
{
    public class UpdateCommentCommand : IUpdateCommentCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public UpdateCommentCommand(IDatabaseService databaseService, IMapper mapper)
        {
            _databaseService = databaseService;
            _mapper = mapper;
        }
        public async Task<UpdateCommentModel> Execute(UpdateCommentModel model) 
        {
            var entity = _mapper.Map<CommentEntity>(model);
            _databaseService.CommentEntity.Update(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
