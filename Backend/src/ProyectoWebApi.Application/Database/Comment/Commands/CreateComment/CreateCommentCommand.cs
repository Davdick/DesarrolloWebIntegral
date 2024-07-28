using AutoMapper;
using ProyectoWebApi.DesarrolloIntegral.Domain.Entities.Comment;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment
{
    public class CreateCommentCommand : ICreateCommentCommand
    {
        private readonly IDatabaseService _databaseService;
        private readonly IMapper _mapper;

        public async Task<CreateCommentModel> Execute(CreateCommentModel model)
        {
            var entity = _mapper.Map<CommentEntity>(model);
            await _databaseService.CommentEntity.AddAsync(entity);
            await _databaseService.SaveAsync();
            return model;
        }
    }
}
